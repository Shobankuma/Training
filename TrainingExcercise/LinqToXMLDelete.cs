using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLDelete
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            var bookToDelete = doc.Descendants("Book")
                      .FirstOrDefault(book => book.Element("Title").Value == "The Great Gatsby");

            if (bookToDelete != null)
            {
                bookToDelete.Remove();  // Delete the book element
                doc.Save("updated_bookstore.xml");  // Save the changes
                Console.WriteLine("Book deleted!");
            }

        }
    }
}
