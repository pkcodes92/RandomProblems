/*
 * This class is actually a custom exception that
 * is created for the Left Rotation project. Reason
 * being is that the application can now be able to determine what
 * exactly was the cause of the issue and terminate gracefully.
 */

using System;

namespace ArrayLeftRotation
{
    public class ArrayInputSizeException : Exception
    {
        public ArrayInputSizeException(string message) : base(message)
        {

        }
    }
}