using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        /// <summary>
        /// Сжать массив, удалив из него все 0 и,
        /// заполнить освободившиеся справа элементы значениями –1
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Массив обработанный по заданию</returns>
        static int[] CompressArray(int[] array)
        {
            List<int> compressed = new List<int>();  // Создание списка для хранения сжатого массива

            foreach (int num in array)
            {
                if (num != 0)  // Если элемент не равен 0, добавляем его в список сжатого массива
                {
                    compressed.Add(num);
                }
            }
            int sizeSortArr = compressed.Count(); // Чтобы потом удобнее пройтись по элементам добавленых после сортировки таких как '0'
            int ToAdd = array.Length - compressed.Count;  // Количество нулей, которые нужно добавить в сжатый массив
            compressed.AddRange(new int[ToAdd]);  // Добавление нулей в конец сжатого массива

            for (int i = sizeSortArr; i < array.Length; i++)
            {
                compressed[i] = -1;  // Заполнение освободившихся справа элементов значениями -1
            }

            return compressed.ToArray();  // Преобразование списка обратно в массив и возвращение его
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 0, 2, 0, 3, 4, 0, 5 };
            Console.Write("Массив до обработки: ");
            foreach(int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int[] compressedArray = CompressArray(array);

            Console.WriteLine("Массив после:");
            foreach (int num in compressedArray)
            {
                Console.Write(num + " ");
               
            }
            Console.ReadKey();

        }


    }

}
    

