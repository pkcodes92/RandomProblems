// <copyright file="Stack.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace StackOperations
{
    using System;

    /// <summary>
    /// This class implements the methods defined in <see cref="IStackADT"/>.
    /// </summary>
    public class Stack : IStackADT
    {
        /// <summary>
        /// Gets or sets the stack size set.
        /// </summary>
        public int StackSizeSet { get; set; }

        /// <summary>
        /// The top most element.
        /// </summary>
        public int top;

        readonly object[] item;

        /// <summary>
        /// This is the default constructor.
        /// </summary>
        public Stack()
        {
            StackSizeSet = 10;
            item = new object[StackSizeSet];
            top = -1;
        }

        /// <summary>
        /// Initializes an instance of the stack.
        /// </summary>
        /// <param name="capacity">The stack capacity.</param>
        public Stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new object[StackSizeSet];
            top = -1;
        }

        /// <summary>
        /// This method checks for an empty stack.
        /// </summary>
        /// <returns>Returns a value to indicate whether or not the stack is empty.</returns>
        public bool IsEmpty()
        {
            if (top == -1) return true;
            return false;
        }

        /// <summary>
        /// This method pushes on to the stack.
        /// </summary>
        /// <param name="element">The element to add to the stack.</param>
        public void Push(object element)
        {
            if (top == (StackSizeSet - 1))
            {
                Console.WriteLine("Stack is full!"); 
            }
            else
            {
                item[++top] = element;
                Console.WriteLine("Item pushed successfully!");
            }
        }

        /// <summary>
        /// Removes an element of the stack.
        /// </summary>
        /// <returns>The object that is removed from the stack.</returns>
        public object Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top--];
            }
        }

        /// <summary>
        /// This method looks at the top most element of the stack.
        /// </summary>
        /// <returns>The top most element.</returns>
        public object Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return "No elements";
            }
            else
            {
                return item[top];
            }
        }

        /// <summary>
        /// This method displays all of the elements that are on the stack currently.
        /// </summary>
        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", i + 1, item[i]);
            }
        }
    }
}