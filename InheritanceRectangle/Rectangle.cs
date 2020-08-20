// <copyright file = "Rectangle.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace InheritanceRectangle
{
    using System;

    /// <summary>
    /// This is the rectangle class.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// This represents the length.
        /// </summary>
        protected double length;

        /// <summary>
        /// This represents the width.
        /// </summary>
        protected double width;

        /// <summary>
        /// This is the rectangle constructor.
        /// </summary>
        /// <param name="l">The length.</param>
        /// <param name="w">The width.</param>
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }

        /// <summary>
        /// This method calculates the area.
        /// </summary>
        /// <returns>The area of the rectangle.</returns>
        public double GetArea()
        {
            return length * width;
        }

        /// <summary>
        /// This method outputs to the console.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
}