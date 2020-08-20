// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace MultipleInputs
{
    using System;

    /// <summary>
    /// This is the driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method for this project.
        /// </summary>
        /// <param name="args">Project specific command line arguments.</param>
        public static void Main(string[] args)
        {
            Console.Write("Press t for Table, \n Press f for Factorial \n Press p for Prime \n Press s for search");
            Console.Write("\n\nInput a character value: ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "t":
                    Console.Write("Enter a number: ");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter another number: ");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Table(n1, n2); 
                    break;
                case "f":
                    Console.WriteLine("Enter a number: ");
                    int inputF = Convert.ToInt32(Console.ReadLine());
                    Factorial(inputF);
                    break;
                case "p":
                    Console.WriteLine("Enter a number to check whether or not it is prime: ");
                    int inputP = Convert.ToInt32(Console.ReadLine());
                    break;
                case "s":
                    Console.WriteLine("TBD");
                    break;
                default:
                    Console.WriteLine("TBD");
                    break;
            }

            Console.WriteLine("Program execution has ended, press any key to exit");
            Console.ReadKey();
        }

        private static void Table(int a, int b)
        {
            Console.WriteLine("To be done");
        }

        private static void Factorial(int input)
        {
            Console.WriteLine("To be done");
        }
    }
}