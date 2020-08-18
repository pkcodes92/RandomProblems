// <copyright file="SampStru.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StructBasicsComplexSample
{
    using System;

    /// <summary>
    /// This is the sample struct class.
    /// </summary>
    public struct SampStru
    {
        double val;

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public double Value { get => val; set => val = value; }

        /// <summary>
        /// This method takes in information.
        /// </summary>
        /// <returns>Outputs double values.</returns>
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}