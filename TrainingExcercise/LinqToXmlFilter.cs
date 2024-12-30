using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXmlFilter
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            var programmingBooks = from book in doc.Descendants("Book")
                                   where book.Element("Category").Value == "Programming"
                                   select new
                                   {
                                       Title = book.Element("Title").Value,
                                       Author = book.Element("Author").Element("FirstName").Value + " " +
                                                book.Element("Author").Element("LastName").Value,
                                       Price = book.Element("Price").Value
                                   };

            foreach (var book in programmingBooks)
            {
                Console.WriteLine($"Programming Book: {book.Title} by {book.Author}, Price: {book.Price}");
            }
        }
    }
}



