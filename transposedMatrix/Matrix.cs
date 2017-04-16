using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transposedMatrix
{
    public static class Matrix
    {
        public static int[,] Fill(int length, int width)
        {
            int[,] filledMatrix = new int[length, width];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
                for (int j = 0; j < width; j++)
                {
                    filledMatrix[i, j] = rand.Next(20);
                }
            return filledMatrix;
        }
        public static void Print(int[,] matrix, int length, int width)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
        public static int[,] Transpose(int[,] matrix, int length, int width)
        {
            int[,] transposedMatrix = new int[width, length];
            for (int i = 0; i < length; i++)
                for (int j = 0; j < width; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            return transposedMatrix;
        }
    }
}
