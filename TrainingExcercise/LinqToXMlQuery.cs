using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMlQuery
    {
        public void Run()
        {
            // Load the XML file into XDocument

            XDocument doc = XDocument.Load("BookStore.xml");
            // Query all books
            var books = from book in doc.Descendants("Book")
                    select new
                    {
                        Title = book.Element("Title").Value,
                        Author = book.Element("Author").Element("FirstName").Value + " " +
                                 book.Element("Author").Element("LastName").Value,
                        Price = book.Element("Price").Value
                    };

        // Display all books
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
}
    }
}
