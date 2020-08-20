// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DumpableDemo
{
    using System;

    /// <summary>
    /// This is the main driver class for the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            IDumpable[] a =
            {
                new Fraction(10, 3), 
                new Fraction(9, 4), 
                new Person("Tom", "INDIA", 99556677), 
                new Person("Jerry", "USA", 516444778)
            };

            a[0].Name = "f1";
            a[1].Name = "f2";

            foreach (IDumpable obj in a)
            {
                Console.Write(obj.Name + ": ");
                obj.Dump();
            }

            Console.WriteLine("The program has finished execution - press any key to exit");
            Console.ReadKey(); 
        }
    }
}