﻿namespace DefenseGame
{
    public class OutOfBoundsException : System.Exception
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}
