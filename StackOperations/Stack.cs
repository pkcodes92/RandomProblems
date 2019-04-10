namespace StackOperations
{
    using System;

    public class Stack : IStackADT
    {
        public int StackSizeSet { get; set; }
        public int top;
        readonly object[] item;

        public Stack()
        {
            StackSizeSet = 10;
            item = new object[StackSizeSet];
            top = -1;
        }

        public Stack(int capacity)
        {
            StackSizeSet = capacity;
            item = new object[StackSizeSet];
            top = -1;
        }

        public bool IsEmpty()
        {
            if (top == -1) return true;
            return false;
        }

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

        public void Display()
        {
            for (int i = top; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", i + 1, item[i]);
            }
        }
    }
}