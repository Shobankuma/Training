using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class FileWriter
    {
        public void Run()
        {
            string filePath = @"D:\Training\TrainingExcercise\example.txt";
            // Create a StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text written to the file.");
            } 
        }
    }
}
