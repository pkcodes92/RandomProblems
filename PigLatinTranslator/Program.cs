// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace PigLatinTranslator
{
    using System;

    /// <summary>
    /// This is the main driver class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to translate: ");
            string stringToTranslate = Console.ReadLine();

            Console.WriteLine("Translated into Pig Latin: {0}", PigLatin.Translate(stringToTranslate));
            Console.WriteLine("The program execution has completed - press any key to exit.");
            Console.ReadKey(); 
        }
    }
}