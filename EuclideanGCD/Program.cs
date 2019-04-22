namespace EuclideanGCD
{
    using System;

    class Program
    {
        /// <summary>
        /// This is the main point of execution for the program
        /// </summary>
        /// <param name="args">Any arguments that are required</param>
        static void Main(string[] args)
        {
            Console.Write("Provide a value for the first integer:");
            int firstInt = int.Parse(Console.ReadLine());

            Console.Write(Environment.NewLine);

            Console.Write("Provide a value for the second integer:");
            int secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose either recursive or non-recursive for the implementation of the GCD algorithm");
            string choice = Console.ReadLine();

            int outputResult = 0;
            if (choice == "recursive")
            {
                outputResult = ExecuteGCDRecursive(firstInt, secondInt);
            }
            else
            {
                outputResult = ExecuteGCDNonRecursive(firstInt, secondInt);
            }
        }

        private static int ExecuteGCDRecursive(int a, int b)
        {
            // Base cases returning either integer if one of them is 0!
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            if (a > b)
            {
                return ExecuteGCDRecursive(a % b, b); 
            }
            else
            {
                return ExecuteGCDRecursive(a, b % a);
            }
        }

        private static int ExecuteGCDNonRecursive(int a, int b)
        {
            // This is going to find out which integer gets to 0
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            if (a == 0)
                return b;
            else
                return a;
        }
    }
}