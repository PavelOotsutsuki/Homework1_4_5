using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.Write("Исходный массив: ");
            PrintArray(inputArray);
            Console.WriteLine();

            Shuffle(ref inputArray);

            Console.Write("Массив после перемешивания: ");
            PrintArray(inputArray);
            Console.WriteLine();

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static void Shuffle(ref int[] inputArray)
        {
            int arrayIndex;
            int copyElement;

            Random random = new Random();

            for (int i = 0; i < inputArray.Length; i++)
            {
                arrayIndex = random.Next(0, inputArray.Length);

                copyElement = inputArray[i];
                inputArray[i] = inputArray[arrayIndex];
                inputArray[arrayIndex] = copyElement;
            }
        }

        static void PrintArray(int[] array)
        {
            for (int i=0; i<array.Length-1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.Write(array[array.Length-1]);
        }
    }
}