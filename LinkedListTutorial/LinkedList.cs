/*
 *
 */

using System;

namespace LinkedListTutorial
{
    /// <summary>
    ///  Author   : Pranav S. Krishnamurthy
    ///  Date     : 4th April 2018
    ///  File     : LinkedList.cs
    ///  Purpose  : To contain various properties of a LinkedList and to also 
    ///  encapsulate various methods that belong to the LinkedList data structure.
    /// </summary>
    public class LinkedList
    {
        private Node head;
        private Node current;

        /// <summary>
        /// This represents the count of the nodes in the linked list.
        /// </summary>
        public int Count;

        /// <summary>
        /// Initializes an instance of the <see cref="LinkedList"/> class.
        /// </summary>
        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        /// <summary>
        /// This method adds a node at the end.
        /// </summary>
        /// <param name="data">The node to add.</param>
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++; 
        }

        /// <summary>
        /// This method adds a node at the start of the linked list.
        /// </summary>
        /// <param name="data">The node to add.</param>
        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

        /// <summary>
        /// This method removes a node from the top of the linked list.
        /// </summary>
        public void RemoveFromStart()
        {
            if (Count > 0)
            {
                head.Next = head.Next.Next;
                Count--;
            }
            else
            {
                Console.WriteLine("No element exists in this linked list");
            }
        }

        /// <summary>
        /// This method lists out all nodes in the console UI.
        /// </summary>
        public void PrintAllNodes()
        {
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.Value);
                Console.Write("->");
            }

            Console.Write("NULL");
        }
    }
}