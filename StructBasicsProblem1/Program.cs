// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StructBasicsProblem1
{
    using System;

    /// <summary>
    /// Having the ability to set values as part of a struct data
    /// type in C# - where the members are public by default
    /// </summary>
    public struct ValuesStruct
    {
        /// <summary>
        /// Defines the value of x.
        /// </summary>
        public int x;

        /// <summary>
        /// Defines the value of y.
        /// </summary>
        public int y; 
    }

    /// <summary>
    /// With the classes, you can have members in a class, however
    /// by default they are private as opposed to structs where the
    /// members of structs are actually public by default.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.Write("\n\n Declaring a simple structure: \n");
            Console.Write("-----------------------------------\n");

            ValuesStruct primaryStruct = new ValuesStruct
            {
                x = int.Parse(Console.ReadLine()), 
                y = int.Parse(Console.ReadLine())
            };

            int sum = primaryStruct.x + primaryStruct.y;
            Console.WriteLine($"The sum of {primaryStruct.x} and {primaryStruct.y} is {sum}");

            Console.WriteLine("Execution of this program has completed. You may now press any key to exit");
            Console.ReadKey(); 
        }
    }
}