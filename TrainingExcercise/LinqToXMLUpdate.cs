using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLUpdate
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            var bookToUpdate = doc.Descendants("Book")
                      .FirstOrDefault(book => book.Element("Title").Value == "Introduction to LINQ");

            if (bookToUpdate != null)
            {
                bookToUpdate.Element("Price").Value = "25.99";  // Update price
                doc.Save("updated_bookstore.xml");  // Save the updated XML to a new file
                Console.WriteLine("Price updated!");
            }
        }
    }
}