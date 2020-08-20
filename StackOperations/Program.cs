// <copyright file="Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StackOperations
{
    using System;

    /// <summary>
    /// The main class for this project.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point of execution/driver method.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Stack st = new Stack();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\nStack MENU(size -- 10)");
                Console.WriteLine("1. Add an element");
                Console.WriteLine("2. See the Top element");
                Console.WriteLine("3. Remove top element");
                Console.WriteLine("4. Display stack elements");
                Console.WriteLine("5. Exit");
                Console.Write("Select your choice: ");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element : ");
                        st.Push(Console.ReadLine()); 
                        break;
                    case 2:
                        Console.WriteLine("Top element is: {0}", st.Peek());
                        break;
                    case 3:
                        Console.WriteLine("Element removed: {0}", st.Pop());
                        break;
                    case 4:
                        st.Display(); 
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                }

                Console.WriteLine("Program execution has completed, you may now press any key to exit");
                Console.ReadKey(); 
            }
        }
    }
}