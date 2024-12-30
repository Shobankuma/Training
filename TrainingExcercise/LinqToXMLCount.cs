using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainingExcercise
{
    internal class LinqToXMLCount
    {
        public void Run()
        {
            XDocument doc = XDocument.Load("BookStore.xml");
            int BookCount = doc.Descendants("Book")
                              .Count();
            Console.WriteLine($"Number of  books: {BookCount}");
        }
    }
}