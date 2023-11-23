using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    internal class Program
    {
        static int CountOccurrences(int[] array, int number)
        {
            int count = 0;

            foreach (int num in array)
            {
                if (num == number)  // Если текущий элемент равен заданному числу, увеличиваем счетчик
                {
                    count++;
                }
            }

            return count;
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 2, 5, 2 };

            Console.Write("Введите число: ");
            int userInput = int.Parse(Console.ReadLine());

            int occurrences = CountOccurrences(array, userInput);

            Console.WriteLine($"Число {userInput} встречается в массиве {occurrences} раз(а).");
            Console.ReadKey();
        }
    }
}

