using System;
using System.Collections;
using System.Collections.Generic;

namespace AllLongestStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "aba", "aa", "ad", "vcd", "aba" };
            Console.WriteLine("Input Array: ");
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write(inputArray[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Output: ");

            string[] outputArray = allLongestStrings(inputArray);
            string[] outputArray2 = allLongStrings(inputArray); 

            for (int j = 0; j < outputArray.Length; j++)
            {
                Console.Write(outputArray[j] + " ");
            }

            Console.ReadKey();
        }

        static string[] allLongestStrings(string[] inputArray)
        {
            int max = 0;
            Queue stringQ = new Queue();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    stringQ.Clear();
                    stringQ.Enqueue(inputArray[i]);
                    max = inputArray[i].Length;
                }
                else if (inputArray[i].Length == max)
                {
                    stringQ.Enqueue(inputArray[i]);
                }
            }

            string[] strL = new string[stringQ.Count];
            for (int i = 0; i < strL.Length; i++)
            {
                strL[i] = (string)stringQ.Dequeue(); 
            }

            return strL; 
        }

        static string[] allLongStrings(string[] inputArray)
        {
            int max = 0;

            List<string> lst = new List<string>();

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i].Length > max)
                {
                    lst.Add(inputArray[i]);
                    max = inputArray[i].Length; 
                }
                else if (inputArray[i].Length == max)
                {
                    lst.Add(inputArray[i]);
                }
            }

            var output = lst.ToArray();
            return output; 
        }
    }
}