namespace SpaceCounting
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            Console.Write("\n\n Function to count the number of spaces in a string: \n");
            Console.Write("---------------------------------------------------------\n");
            Console.Write("Please provide a string: ");
            inputStr = Console.ReadLine();

            Console.WriteLine("\"" + inputStr + "\"" + " contains {0} spaces", CountingSpaces(inputStr));

            Console.WriteLine("Program execution has completed, you may now press any key to exit.");
            Console.ReadKey();
        }

        private static int CountingSpaces(string inputString)
        {
            int spcCntr = 0;

            string input;
            for (int i = 0; i < inputString.Length; i++)
            {
                input = inputString.Substring(i, 1);
                if (input == " ")
                {
                    spcCntr++; 
                }
            }

            return spcCntr;
        }
    }
}