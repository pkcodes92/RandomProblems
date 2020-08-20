// <copyright file="Square.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StructBasicsComplexSample
{
    using System;

    /// <summary>
    /// This is a class to represent the struct for a square.
    /// </summary>
    public struct Square
    {
        SampStru ln;
        SampStru ht;

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        public SampStru Length
        {
            get { return ln; }
            set { ln = value; }
        }

        /// <summary>
        /// Gets or sets the breadth.
        /// </summary>
        public SampStru Breadth
        {
            get { return ht; }
            set { ht = value; }
        }

        /// <summary>
        /// This method intializes a new square.
        /// </summary>
        public void NewSquare()
        {
            SampStru rect = new SampStru();
            Console.WriteLine("\nInput the dimensions of the Square( equal length and breadth ) : ");
            ln = SqrLength();
            Console.Write("breadth : ");
            ht.Value = rect.Read();
        }

        /// <summary>
        /// This method initializes a new quadrilateral which is a square.
        /// </summary>
        /// <returns>A sample struct which is a square with equal length and width.</returns>
        public SampStru SqrLength()
        {
            SampStru rct = new SampStru();
            Console.Write("length : ");
            rct.Value = rct.Read();
            return rct;
        }
    }
}