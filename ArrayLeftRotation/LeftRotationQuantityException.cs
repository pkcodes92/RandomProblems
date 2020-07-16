// <copyright file="LeftRotationQuantityException.cs" company="TCS Ltd">
// Copyright (c) TCS Ltd. All rights reserved.
// </copyright>

namespace ArrayLeftRotation
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class LeftRotationQuantityException : Exception
    {
        public LeftRotationQuantityException(string message) : base(message)
        {
        }

        protected LeftRotationQuantityException(SerializationInfo serializationInfo, StreamingContext streamingContext)
        {
        }
    }
}