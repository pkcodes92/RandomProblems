namespace MasterOfAllProblems.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This is the input size exception class.
    /// </summary>
    [Serializable]
    public class ArrayInputSizeException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public ArrayInputSizeException(string message) : base(message)
        {
        }
    }
}