using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class MultiArray
    { 
        public void Run()
        {
            // Declaring and initializing a 2D array (matrix)
            int[,] matrix = new int[2, 3];

            // Assigning values to the matrix
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;

            // Accessing and displaying the values
            for (int i = 0; i < matrix.GetLength(0); i++)  // GetLength(0) gives the number of rows
            {
                for (int j = 0; j < matrix.GetLength(1); j++)  // GetLength(1) gives the number of columns
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}

