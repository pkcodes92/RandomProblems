// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StructBasicsComplexSample
{
    using System;

    /// <summary>
    /// This is the main class of the project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The driver method of this project/main entry point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Console.Write("\n\nMethod that returns a structure : \n");
            Console.Write("--------------------------------------\n");

            var sqre = new Square();
            sqre.NewSquare();

            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square : ");
            Console.WriteLine("Length:      {0}", sqre.Length.Value);
            Console.WriteLine("Breadth:     {0}", sqre.Breadth.Value);
            Console.WriteLine("Perimeter:   {0}", (sqre.Length.Value + sqre.Breadth.Value) * 2);
            Console.WriteLine("Area:        {0}\n", sqre.Length.Value * sqre.Breadth.Value);

            Console.WriteLine("Execution of the program has finished. You can press any key to exit");
            Console.ReadKey();
        }
    }
}