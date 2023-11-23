using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    internal class Program
    {
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] transposedMatrix = new int[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];  // Заполнение транспонированной матрицы соответствующими элементами исходной матрицы
                }
            }

            Console.WriteLine("Транспонированная матрица:");
            PrintMatrix(transposedMatrix);
            Console.ReadKey();
        }
    }
}
