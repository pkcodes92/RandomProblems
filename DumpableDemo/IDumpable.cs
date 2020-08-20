// <copyright file="IDumpable.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace DumpableDemo
{
    /// <summary>
    /// This interface defines the various methods and properties which can be inherited.
    /// </summary>
    public interface IDumpable
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// This method will be printing to the console.
        /// </summary>
        void Dump(); 
    }
}
