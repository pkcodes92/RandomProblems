// <copyright file="LeftRotationQuantityException.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ArrayLeftRotation
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// This class is the array quantity exception class.
    /// </summary>
    [Serializable]
    public class LeftRotationQuantityException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message">The message to render on the screen.</param>
        public LeftRotationQuantityException(string message) : base(message)
        {
        }

        /// <summary>
        /// This is the protected constructor.
        /// </summary>
        /// <param name="serializationInfo">The serialization info.</param>
        /// <param name="streamingContext">The current streaming context.</param>
        protected LeftRotationQuantityException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}