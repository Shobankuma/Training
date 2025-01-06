using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    internal class Filesstream
    {
        public void Run()
        {
            string filePath = @"D:\Training\TrainingExcercise\example.txt";
            // Open the file with FileStream for reading
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] byteArray = new byte[fs.Length];
                fs.Read(byteArray, 0, (int)fs.Length);

                // Convert the byte array to a string and display it
                string fileContent = System.Text.Encoding.UTF8.GetString(byteArray);
                Console.WriteLine(fileContent);
            }
        }
    }
}
