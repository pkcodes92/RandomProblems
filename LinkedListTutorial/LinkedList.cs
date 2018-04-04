/*
 * Author   : Pranav S. Krishnamurthy
 * 
 * Date     : 4th April 2018
 * 
 * File     : LinkedList.cs
 * 
 * Purpose  : To contain various properties of a LinkedList and to also
 *            encapsulate various methods that belong to the LinkedList
 *            data structure.
 */

using System;

namespace LinkedListTutorial
{
    public class LinkedList
    {
        private Node head;
        private Node current;
        public int Count;

        public LinkedList()
        {
            head = new Node();
            current = head;
        }

        #region Methods for the LinkedList
        public void AddAtLast(object data)
        {
            Node newNode = new Node();
            newNode.Value = data;
            current.Next = newNode;
            current = newNode;
            Count++; 
        }

        public void AddAtStart(object data)
        {
            Node newNode = new Node() { Value = data };
            newNode.Next = head.Next;
            head.Next = newNode;
            Count++;
        }

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
        #endregion
    }
}