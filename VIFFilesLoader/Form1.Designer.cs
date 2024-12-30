namespace VIFFilesLoader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox txtGRL;
        private System.Windows.Forms.TextBox txtUSB;
        private System.Windows.Forms.Button btnLoadGRL;
        private System.Windows.Forms.Button btnLoadUSB;
        private System.Windows.Forms.Button btnCompareAndSave;
        private System.Windows.Forms.Label lblGRL;
        private System.Windows.Forms.Label lblUSB;



        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
       
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.txtGRL = new System.Windows.Forms.TextBox();
            this.txtUSB = new System.Windows.Forms.TextBox();
            this.btnLoadGRL = new System.Windows.Forms.Button();
            this.btnLoadUSB = new System.Windows.Forms.Button();
            this.btnCompareAndSave = new System.Windows.Forms.Button();
            this.lblGRL = new System.Windows.Forms.Label();
            this.lblUSB = new System.Windows.Forms.Label();

            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select GRL XML File";

            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialog2.Title = "Select USB XML File";

            // 
            // txtGRL
            // 
            this.txtGRL.Location = new System.Drawing.Point(115, 25);
            this.txtGRL.Name = "txtGRL";
            this.txtGRL.Size = new System.Drawing.Size(200, 20);
            this.txtGRL.TabIndex = 0;

            // 
            // txtUSB
            // 
            this.txtUSB.Location = new System.Drawing.Point(115, 60);
            this.txtUSB.Name = "txtUSB";
            this.txtUSB.Size = new System.Drawing.Size(200, 20);
            this.txtUSB.TabIndex = 1;

            // 
            // btnLoadGRL
            // 
            this.btnLoadGRL.Location = new System.Drawing.Point(320, 25);
            this.btnLoadGRL.Name = "btnLoadGRL";
            this.btnLoadGRL.Size = new System.Drawing.Size(75, 23);
            this.btnLoadGRL.TabIndex = 2;
            this.btnLoadGRL.Text = "Load GRL";
            this.btnLoadGRL.UseVisualStyleBackColor = true;
            this.btnLoadGRL.Click += new System.EventHandler(this.BtnLoadGRL_Click);

            // 
            // btnLoadUSB
            // 
            this.btnLoadUSB.Location = new System.Drawing.Point(320, 60);
            this.btnLoadUSB.Name = "btnLoadUSB";
            this.btnLoadUSB.Size = new System.Drawing.Size(75, 23);
            this.btnLoadUSB.TabIndex = 3;
            this.btnLoadUSB.Text = "Load USB";
            this.btnLoadUSB.UseVisualStyleBackColor = true;
            this.btnLoadUSB.Click += new System.EventHandler(this.BtnLoadUSB_Click);

            // 
            // btnCompareAndSave
            // 
            this.btnCompareAndSave.Location = new System.Drawing.Point(320, 95);
            this.btnCompareAndSave.Name = "btnCompareAndSave";
            this.btnCompareAndSave.Size = new System.Drawing.Size(120, 23);
            this.btnCompareAndSave.TabIndex = 4;
            this.btnCompareAndSave.Text = "Compare and Save";
            this.btnCompareAndSave.UseVisualStyleBackColor = true;
            this.btnCompareAndSave.Click += new System.EventHandler(this.BtnCompare_Click);

            // 
            // lblGRL
            // 
            this.lblGRL.AutoSize = true;
            this.lblGRL.Location = new System.Drawing.Point(25, 28);
            this.lblGRL.Name = "lblGRL";
            this.lblGRL.Size = new System.Drawing.Size(59, 13);
            this.lblGRL.TabIndex = 5;
            this.lblGRL.Text = "GRL VIF:";

            // 
            // lblUSB
            // 
            this.lblUSB.AutoSize = true;
            this.lblUSB.Location = new System.Drawing.Point(25, 63);
            this.lblUSB.Name = "lblUSB";
            this.lblUSB.Size = new System.Drawing.Size(81, 13);
            this.lblUSB.TabIndex = 6;
            this.lblUSB.Text = "USB IF VIF:";

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(460, 150);
            this.Controls.Add(this.lblUSB);
            this.Controls.Add(this.lblGRL);
            this.Controls.Add(this.btnCompareAndSave);
            this.Controls.Add(this.btnLoadUSB);
            this.Controls.Add(this.btnLoadGRL);
            this.Controls.Add(this.txtUSB);
            this.Controls.Add(this.txtGRL);
            this.Name = "Form1";
            this.Text = "XML Compare and Update";


        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }

}

