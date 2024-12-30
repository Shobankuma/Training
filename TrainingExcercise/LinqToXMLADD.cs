using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLADD
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            XElement newBook = new XElement("Book",
            new XAttribute("id", "7"),
            new XElement("Title", "The Pragmatic Programmer"),
            new XElement("Author",
                new XElement("FirstName", "Andrew"),
                new XElement("LastName", "Hunt")),
            new XElement("Category", "Programming"),
            new XElement("Price", new XAttribute("currency", "USD"), "39.99"),
            new XElement("PublishedYear", "1999")
);

            // Add the new book to the Books element
            doc.Element("Bookstore").Element("Books").Add(newBook);

            // Save the updated XML to a new file
            doc.Save("updated_bookstore.xml");

            Console.WriteLine("New book added!");

        }
    }

}

