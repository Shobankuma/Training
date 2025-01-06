using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TrainingExcercise
{
    internal class FileReader
    {
        public void Run()
        {
            string filePath = @"D:\Training\TrainingExcercise\example.txt";

            // Create a StreamReader to read the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
