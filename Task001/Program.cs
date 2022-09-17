using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задать массив случайных положительных трехзначных чисел и показать количество четных чисел в массиве

            // метод создает массив

            int[] GetArray(int size, int start, int end)
            {
                int[] array = new int[size];

                var random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(start, end);
                }
                return array;
            }

            // метод подсчета четных чисел в массиве

            int GetEvenDigits(int[] array)
            {
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            // метод печатает массив

            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }



            int[] myArray = GetArray(20, 100, 1000);

            PrintArray(myArray);

            int result = GetEvenDigits(myArray);

            Console.WriteLine($"В массиве {result} четных чисел");


        }
    }
}
