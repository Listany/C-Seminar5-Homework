using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создать массив вещественных чисел, найти разницу между макс и мин значениями

            double[] GetArray(int size)
            {
                double[] array = new double[size];

                var random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.NextDouble()*100+1;
                    array[i] = Math.Round(array[i], 2);
                }


                return array;
            }

            void PrintArray(double[] array) // метод печатает массив
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            // метод находит разницу между макс и мин

            double GetDiffMaxMin(double[] array)
            {
                double diff = 0;
                double max = array[0];
                double min = array[0];

                //находим макс
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max )
                    {
                        max = array[i];
                    }
                }

                //находим мин
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                diff = max - min;
                return diff;
            }


            double[] myArray = GetArray(10);

            PrintArray(myArray);

            double result = GetDiffMaxMin(myArray);

            Console.WriteLine($"Разница между максимальным и минимальным значением в массиве равна {result}");

        }
    }
}
