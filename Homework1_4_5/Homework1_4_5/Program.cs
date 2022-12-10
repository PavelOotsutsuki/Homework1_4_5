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

            outputArray1 = Shuffle2(inputArray);
            outputArray2 = Shuffle2(inputArray);

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

        static int[] Shuffle2(int[] inputArray)
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

            return inputArray;
        }

        static int[] Shuffle(int [] inputArray)
        {
            int[] outputArray = new int[inputArray.Length];
            int arrayIndex;
            int copyElement;

            Random random = new Random();
            
            for (int i=0; i<outputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }

            for (int i=0; i<outputArray.Length;i++)
            {
                arrayIndex= random.Next(0, outputArray.Length);

                copyElement = outputArray[i];
                outputArray[i] = outputArray[arrayIndex];
                outputArray[arrayIndex] = copyElement;
            }

            return outputArray;
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