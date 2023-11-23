using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        /// <summary>
        /// Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а затем положительные:
        /// </summary>
        /// <param name="array"></param>
        /// <returns>преобразованый массив</returns>
        static int[] SortArray(int[] array)
        {
            Array.Sort(array, (x, y) =>
            {
                if (x < 0 && y >= 0)  // Если x отрицательное, а y положительное, x должно быть перед y в отсортированном массиве
                {
                    return -1;
                }
                else if (x >= 0 && y < 0)  // Если x положительное, а y отрицательное, y должно быть перед x в отсортированном массиве
                {
                    return 1;
                }
                else
                {
                    return x.CompareTo(y);  // Если x и y одного знака, сравниваем их значения обычным способом
                }
            });

            return array;
        }

        static void Main()
        {
            int[] array = { 3, -1, 0, -4, 2, 5, -2 };
            int[] sortedArray = SortArray(array);

            Console.WriteLine("Array:");
            foreach (int num in sortedArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}

