// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace FibonacciNumbers
{
    using System;

    /// <summary>
    /// This is the main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the main point of entry when it comes to the execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of digits to print out for the Fibonnaci sequence: ");
            int len = int.Parse(Console.ReadLine());

            Console.WriteLine("Now use either 1 or 2 to find out how to print those numbers. 1 represents an iterative approach, while 2 represents the recursive approach");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                FibonacciIterative(len); 
            }

            if (choice == "2")
            {
                FibonacciRecursive(len); 
            }

            Console.WriteLine("The program has completed execution, you may now press any key to quit"); 
            Console.ReadKey();
        }

        private static void FibonacciIterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        private static void FibonacciRecursive(int len)
        {
            FibonacciRecursiveTemp(0, 1, 1, len);
        }

        private static void FibonacciRecursiveTemp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.Write("{0}", a);
                FibonacciRecursiveTemp(b, a + b, counter + 1, len);
            }
        }
    }
}