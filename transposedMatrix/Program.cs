using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transposedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int width = 6;

            int[,] matrix = Matrix.Fill(length, width); 

            Matrix.Print(matrix, length, width);
            Console.WriteLine();

            int[,] transposedMatrix = Matrix.Transpose(matrix, length, width);
            Matrix.Print(transposedMatrix, width, length);            

            Console.ReadLine();              
        }
    }
}
