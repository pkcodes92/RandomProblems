namespace ArrayLeftRotation
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
        /// This is the exception constructor using a message.
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public ArrayInputSizeException(string message) : base(message)
        {
        }

        /// <summary>
        /// Another constructor for the ArrayInputSizeException.
        /// </summary>
        /// <param name="serializationInfo">The serialization information.</param>
        /// <param name="streamingContext">The streaming context.</param>
        protected ArrayInputSizeException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}