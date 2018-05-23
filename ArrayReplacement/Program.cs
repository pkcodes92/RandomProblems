using System;

namespace ArrayReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[] { 1, 2, 1 };

            int elemToReplace = 1;

            int substitutionElem = 3;

            int[] finalArray = ArrayReplace(inputArray, elemToReplace, substitutionElem);

            for (int i = 0; i < finalArray.Length; i++)
            {
                Console.Write(finalArray[i] + " ");
            }

            Console.ReadKey();
        }

        static int[] ArrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            int[] temp = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == elemToReplace)
                {
                    temp[i] += substitutionElem;
                }
                else
                {
                    temp[i] += inputArray[i];
                }
            }

            return temp;
        }
    }
}