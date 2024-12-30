using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLSorting
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            var sortedBooks = from book in doc.Descendants("Book")
                              orderby (int)book.Element("PublishedYear")
                              select new
                              {
                                  Title = book.Element("Title").Value,
                                  Author = book.Element("Author").Element("FirstName").Value + " " +
                                           book.Element("Author").Element("LastName").Value,
                                  Year = book.Element("PublishedYear").Value
                              };

            foreach (var book in sortedBooks)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Published Year: {book.Year}");
            }

        }
    }
}
