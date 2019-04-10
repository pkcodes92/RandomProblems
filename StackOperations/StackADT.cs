namespace StackOperations
{
    using System;

    public interface IStackADT
    {
        bool IsEmpty();
        void Push(object element);
        object Pop();
        object Peek();
        void Display(); 
    }
}