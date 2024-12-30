using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace VIFFilesLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        public enum ConnectorType
        {
            TYPE_A = 0,
            TYPE_B = 1,
            TYPE_C = 2
        }
        // Load GRL VIF XML file
        private void BtnLoadGRL_Click(object sender, EventArgs e)
        {
            // Open file dialog to select the GRL XML file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string grlFilePath = openFileDialog1.FileName;
                    XElement grlXml = XElement.Load(grlFilePath);

                    // Check for Vendor_Name consistency
                    string grlVendorName = grlXml.Descendants("{http://usb.org/VendorInfoFile.xsd}Vendor_Name").FirstOrDefault()?.Value;

                    if (string.IsNullOrEmpty(grlVendorName))
                    {
                        MessageBox.Show("GRL XML is missing <vif:Vendor_Name>.");
                        return;
                    }

                    txtGRL.Text = grlFilePath;  // Display file path in TextBox

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading GRL XML: " + ex.Message);
                }
            }
        }

        private void BtnLoadUSB_Click(object sender, EventArgs e)
        {
            // Open file dialog to select the USB XML file
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string grlFilePath = openFileDialog1.FileName;
                    string usbFilePath = openFileDialog2.FileName;
                    XElement usbXml = XElement.Load(usbFilePath);
                    XElement grlXml = XElement.Load(grlFilePath);

                    // Check for Vendor_Name consistency
                    string usbVendorName = usbXml.Descendants("{http://usb.org/VendorInfoFile.xsd}Vendor_Name").FirstOrDefault()?.Value;
                    string grlVendorName = grlXml.Descendants("{http://usb.org/VendorInfoFile.xsd}Vendor_Name").FirstOrDefault()?.Value;

                    if (string.IsNullOrEmpty(usbVendorName))
                    {
                        MessageBox.Show("USB XML is missing <vif:Vendor_Name>.");
                        return;
                    }

                    // If Vendor Names don't match, show an error
                    if (grlVendorName != usbVendorName)
                    {
                        MessageBox.Show("Vendor names do not match in both files.");
                        return;
                    }

                    txtUSB.Text = usbFilePath;  // Display file path in TextBox

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading USB XML: " + ex.Message);
                }
            }
        }

        private void BtnCompare_Click(object sender, EventArgs e)
        {
            try
            {
                // Load both XML files
                XElement grlXml = XElement.Load(txtGRL.Text);
                XElement usbXml = XElement.Load(txtUSB.Text);

                // Compare each line of both XMLs (assuming they are similar)
                var grlVendorName = grlXml.Descendants("{http://usb.org/VendorInfoFile.xsd}Vendor_Name").FirstOrDefault()?.Value;
                var usbVendorName = usbXml.Descendants("{http://usb.org/VendorInfoFile.xsd}Vendor_Name").FirstOrDefault()?.Value;

                if (grlVendorName != usbVendorName)
                {
                    MessageBox.Show("The Vendor Name mismatch detected. Cannot compare further.");
                    return;
                }

                // Perform the comparison and merge/update
                CompareAndUpdateXml(grlXml, usbXml);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during comparison or saving: " + ex.Message);
            }
        }

        private void CompareAndUpdateXml(XElement grlXml, XElement usbXml)
        {
            // Define the namespace used in both XML documents.
            XNamespace ns = "http://usb.org/VendorInfoFile.xsd";

            // Iterate through each <vif:Component> element in GRL XML
            foreach (var grlElement in grlXml.Descendants(ns + "Component"))
            {
                // Find the matching <vif:Component> element in USB
                var usbElement = usbXml.Descendants(ns + "Component")
                                       .FirstOrDefault(usb => usb.Element(ns + "ComponentID")?.Value == grlElement.Element(ns + "ComponentID")?.Value);

                if (usbElement != null)
                {
                    // Iterate through each child element in the USB <vif:Component> element
                    foreach (var childElement in usbElement.Elements())
                    {
                        // Check if the corresponding child element already exists in GRL
                        var correspondingElement = grlElement.Element(childElement.Name);
                        if (correspondingElement == null)
                        {
                            // If the child element doesn't exist, add it to GRL
                            grlElement.Add(new XElement(childElement));
                        }
                    }
                }
            }


            // Iterate through each <vif:SOPSVID> element in GRL
            foreach (var grlSopsvidElement in grlXml.Descendants(ns + "SOPSVID"))
            {
                // Extract the value of the attribute "value" from GRL XML's SVID_SOP
                var grlSvidSopValue = grlSopsvidElement.Element(ns + "SVID_SOP")?.Attribute("value")?.Value;

                // Find the matching <vif:SOPSVID> element in USB based on the "value" attribute
                var usbSopsvidElement = usbXml.Descendants(ns + "SOPSVID")
                    .FirstOrDefault(usb => usb.Element(ns + "SVID_SOP")?.Attribute("value")?.Value == grlSvidSopValue);

                // If a matching <vif:SOPSVID> element is found in USB, proceed
                if (usbSopsvidElement != null)
                {
                    // Find the <vif:SVID_Mode_Recog_Value_SOP> element in the USB XML
                    var usbModeRecogValue = usbSopsvidElement.Descendants(ns + "SVID_Mode_Recog_Value_SOP").FirstOrDefault();

                    // If the <vif:SVID_Mode_Recog_Value_SOP> exists in USB and is missing in GRL
                    if (usbModeRecogValue != null)
                    {
                        // Find the <vif:SOPSVIDModeList> element in GRL XML
                        var grlSopsvidModeList = grlSopsvidElement.Element(ns + "SOPSVIDModeList");

                        // Find the first <vif:SOPSVIDMode> element in GRL (since there should only be one)
                        var grlSopsvidModeElement = grlSopsvidModeList?.Element(ns + "SOPSVIDMode");

                        // Check if the <vif:SVID_Mode_Recog_Value_SOP> already exists under <vif:SOPSVIDMode>
                        var grlModeRecogValue = grlSopsvidModeElement?.Descendants(ns + "SVID_Mode_Recog_Value_SOP").FirstOrDefault();

                        // If it doesn't exist, add it to the existing <vif:SOPSVIDMode> element
                        if (grlModeRecogValue == null)
                        {
                            grlSopsvidModeElement?.Add(new XElement(usbModeRecogValue));
                        }
                    }
                }
            }

            // Iterate through each <vif:CableSVID> element in GRL
            foreach (var grlCableSvidElement in grlXml.Descendants(ns + "CableSVID"))
            {
                // Extract the value of the attribute "value" from GRL XML's SVID
                var grlSvidValue = grlCableSvidElement.Element(ns + "SVID")?.Attribute("value")?.Value;

                // Find the matching <vif:CableSVID> element in USB based on the "value" attribute
                var usbCableSvidElement = usbXml.Descendants(ns + "CableSVID")
                    .FirstOrDefault(usb => usb.Element(ns + "SVID")?.Attribute("value")?.Value == grlSvidValue);

                // If a matching <vif:CableSVID> element is found in USB, proceed
                if (usbCableSvidElement != null)
                {
                    // Find the <vif:SVID_Mode_Recog_Value> element in the USB XML
                    var usbModeRecogValue = usbCableSvidElement.Descendants(ns + "SVID_Mode_Recog_Value").FirstOrDefault();

                    // If the <vif:SVID_Mode_Recog_Value> exists in USB and is missing in GRL
                    if (usbModeRecogValue != null)
                    {
                        // Find the <vif:CableSVIDModeList> element in GRL XML
                        var grlCableSvidModeList = grlCableSvidElement.Element(ns + "CableSVIDModeList");

                        // Find the first <vif:CableSVIDMode> element in GRL (since there should only be one)
                        var grlCableSvidModeElement = grlCableSvidModeList?.Element(ns + "CableSVIDMode");

                        // Check if the <vif:SVID_Mode_Recog_Value> already exists under <vif:CableSVIDMode>
                        var grlCableModeRecogValue = grlCableSvidModeElement?.Descendants(ns + "SVID_Mode_Recog_Value").FirstOrDefault();

                        // If it doesn't exist, add it to the existing <vif:CableSVIDMode> element
                        if (grlCableModeRecogValue == null)
                        {
                            grlCableSvidModeElement?.Add(new XElement(usbModeRecogValue));
                        }
                    }
                }
            }


            // Update values for elements with "YES"/"NO" and "1"/"0" for "value" attribute
            foreach (var grlElement in grlXml.Descendants())
            {
                var grlValue = grlElement.Attribute("value")?.Value;

                // Check if the value is "1" or "0" and the corresponding text is "YES" or "NO"
                if (grlValue == "1" || grlValue == "0")
                {
                    string text = grlElement.Value.Trim();

                    if (text == "YES")
                    {
                        // If the text is "YES", update value to true
                        grlElement.SetAttributeValue("value", true);
                    }
                    else if (text == "NO")
                    {
                        // If the text is "NO", update value to false
                        grlElement.SetAttributeValue("value", false);
                    }
                }
            }

            // Now handle specific update logic for the Connector_Type element using Enum
            foreach (var grlConnectorElement in grlXml.Descendants(ns + "Connector_Type"))
            {
                string connectorTypeText = grlConnectorElement.Value.Trim();
                ConnectorType? newConnectorValue = null;

                // Match the Connector Type to its respective numeric value using the enum
                switch (connectorTypeText)
                {
                    case "USB TYPE_A":
                        newConnectorValue = ConnectorType.TYPE_A;
                        break;
                    case "USB TYPE_B":
                        newConnectorValue = ConnectorType.TYPE_B;
                        break;
                    case "USB TYPE_C":
                        newConnectorValue = ConnectorType.TYPE_C;
                        break;
                }

                // If a valid mapping is found, update the value attribute
                if (newConnectorValue.HasValue)
                {
                    grlConnectorElement.SetAttributeValue("value", (int)newConnectorValue.Value);
                }
            }

            try
            {
                // Open SaveFileDialog to let the user choose where to save the updated XML file
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "xml";
                    saveFileDialog.AddExtension = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // Save the updated XML to the selected file
                            grlXml.Save(saveFileDialog.FileName);
                            MessageBox.Show("Updated XML has been saved successfully as: " + saveFileDialog.FileName);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving the updated XML: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during comparison or saving: " + ex.Message);
            }
        }
    }

    }




