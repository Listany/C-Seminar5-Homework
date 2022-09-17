using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задать массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечетных позициях

            int[] GetArray(int size, int start, int end) // метод генерирует массив
            {
                int[] array = new int[size];

                var random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(start, end);

                }
                return array;
            }

            void PrintArray(int[] array) // метод печатает массив
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            // метод находит сумму элементов на нечетных позициях

            int GetSumOdd (int[] array)
            {
                int sumOdd = 0;

                for (int i = 1; i < array.Length; i += 2)
                {
                    sumOdd = sumOdd + array[i];
                }
                return sumOdd;
            }


            int [] myArray = GetArray(10, 1, 20);

            PrintArray(myArray);

            Console.WriteLine($"Сумма элементов массива на нечетных позициях равна {GetSumOdd(myArray)}");
        }
    }
}
