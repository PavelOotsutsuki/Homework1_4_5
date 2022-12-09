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
            int[] outputArray1;
            int[] outputArray2;

            outputArray1 = Shuffle(inputArray);
            outputArray2 = Shuffle(inputArray);

            Console.Write("Исходный массив: ");
            PrintArray(inputArray);
            Console.WriteLine();
            Console.Write("Первый массив: ");
            PrintArray(outputArray1);
            Console.WriteLine();
            Console.Write("Второй массив: ");
            PrintArray(outputArray2);
            Console.WriteLine();

            Console.Write("Для продолжения нажмите любую кнопку...");
            Console.ReadKey();
        }

        static int[] Shuffle(int [] inputArray)
        {
            int[] outputArray = new int[inputArray.Length];
            int arrayElementPosition;
            int copyElement;

            Random random = new Random();
            
            for (int arrayIndex=0; arrayIndex<outputArray.Length; arrayIndex++)
            {
                outputArray[arrayIndex] = inputArray[arrayIndex];
            }

            for (int arrayIndex=0; arrayIndex<outputArray.Length;arrayIndex++)
            {
                arrayElementPosition= random.Next(0, outputArray.Length);

                copyElement = outputArray[arrayIndex];
                outputArray[arrayIndex] = outputArray[arrayElementPosition];
                outputArray[arrayElementPosition] = copyElement;
            }

            return outputArray;
        }

        static void PrintArray(int[] array)
        {
            for (int arrayIndex=0; arrayIndex<array.Length; arrayIndex++)
            {
                Console.Write(array[arrayIndex]);

                if(arrayIndex!=array.Length-1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}