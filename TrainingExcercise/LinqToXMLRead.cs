using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLRead
    {
        public void Run()
        {
            // Load the XML file into XDocument
           
    XDocument doc = XDocument.Load("BookStore.xml");
            XDocument doc1 = XDocument.Load("updated_bookstore.xml");
            // Output the contents of the XML file
           // Console.WriteLine(doc);
            Console.WriteLine(doc1);
        }
    }

}
