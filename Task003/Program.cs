using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Найти произведения пар чисел в одномерном массиве (первый и последний и тд). Результат в отдельный массив

            int[] GetArray(int size, int start, int finish) // метод генерирует массив
            {
                int[] array = new int[size];

                var random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(start, finish);

                }
                return array;
            }

            // Метод находит произведения пар элементов

            int[] GetMultiCouple (int[] array)
            {
                int start = 0;
                int end = array.Length - 1;

                int size = array.Length/2;

                if (array.Length % 2 != 0)                
                {
                    size = array.Length/2 + 1;
                }


                int[] arrayResult = new int[size];

                while (end - start >= 0)
                {
                    if (end - start > 0)
                    {
                        arrayResult[start] = array[start] * array[end];
                        
                    }
                    else
                    {
                        arrayResult[start] = array[start];
                        
                    }
                    start++;
                    end--;

                }
                    
                return arrayResult;

            }

            void PrintArray(int[] array) // метод печатает массив
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            int[] myArray = GetArray(5, 1, 11);

            Console.WriteLine("Заданный массив равен: ");
            PrintArray(myArray);

            int[] myArrayResult = GetMultiCouple(myArray);

            Console.WriteLine("Полученный массив равен: ");
            PrintArray(myArrayResult);

            Console.ReadLine();

        }
    }
}
