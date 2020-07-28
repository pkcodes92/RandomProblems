// <copyright file = "Program.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace GetHashCodeTutorial
{
    using System;

    /// <summary>
    /// This is the definition of our struct.
    /// </summary>
    public struct Number
    {
        private int n; 

        /// <summary>
        /// This is the number constructor.
        /// </summary>
        /// <param name="value">The number to construct the struct from.</param>
        public Number(int value)
        {
            n = value;
        }

        /// <summary>
        /// Gets the numerical value.
        /// </summary>
        public int Value
        {
            get { return n; }
        }

        /// <summary>
        /// Method to check if the values are equal.
        /// </summary>
        /// <param name="obj">The object to check.</param>
        /// <returns>A boolean value that determines whether or not the entities are equal.</returns>
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Number))
            {
                return false;
            }
            else
            {
                return n == ((Number)obj).n;
            }
        }

        /// <summary>
        /// GetHashCode() method must be overridden along with 
        /// the Equals() method
        /// </summary>
        /// <returns>Integer</returns>
        public override int GetHashCode()
        {
            return n; 
        }

        /// <summary>
        /// This method outputs to a string.
        /// </summary>
        /// <returns>The string of the value.</returns>
        public override string ToString()
        {
            return n.ToString();
        }

        /// <summary>
        /// This method will check if the entities are equal.
        /// </summary>
        /// <param name="left">The left value.</param>
        /// <param name="right">The right value.</param>
        /// <returns>A boolean value that will note if the left and right are equal.</returns>
        public static bool operator ==(Number left, Number right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// This method will tell if the left and right entities are not equal.
        /// </summary>
        /// <param name="left">The left value.</param>
        /// <param name="right">The right value.</param>
        /// <returns>A boolean value result.</returns>
        public static bool operator !=(Number left, Number right)
        {
            return !(left == right);
        }
    }

    /// <summary>
    /// This is the main class for execution.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is the main method/point of execution.
        /// </summary>
        /// <param name="args">Project specific arguments.</param>
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int ctr = 0; ctr <= 9; ctr++)
            {
                int randomNum = rnd.Next(int.MinValue, int.MaxValue);
                Number n = new Number(randomNum);
                Console.WriteLine("n = {0,12}, hash code = {1, 12}", n, n.GetHashCode());
            }

            Console.ReadKey(); 
        }
    }
}