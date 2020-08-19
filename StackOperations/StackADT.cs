// <copyright file="IStackADT.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StackOperations
{
    using System;

    /// <summary>
    /// This interface defines the methods for the stack operations.
    /// </summary>
    public interface IStackADT
    {
        /// <summary>
        /// A method to see if the stack is empty.
        /// </summary>
        /// <returns>A true or false value.</returns>
        bool IsEmpty();

        /// <summary>
        /// This method will push an element on to the stack.
        /// </summary>
        /// <param name="element">The element to push on the stack.</param>
        void Push(object element);

        /// <summary>
        /// Takes the top most element of the stack.
        /// </summary>
        /// <returns>An element from the stack.</returns>
        object Pop();

        /// <summary>
        /// This method will view the top most element of the stack.
        /// </summary>
        /// <returns>The top most element of the stack.</returns>
        object Peek();

        /// <summary>
        /// This method will simply display all elements on the stack currently.
        /// </summary>
        void Display(); 
    }
}