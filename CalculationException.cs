using System;

namespace Exception_Handling_Demo
{
    public class CalculationException : Exception
    {
        private const string DefaultMessage = "Otomatik mesaj";


        /// <summary>
        /// Create a new exception with default message.
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {
        }

        /// <summary>
        /// Crate a new exception with user-supplied message.
        /// </summary>
        /// <param name="message"></param>
        public CalculationException(string message) : base(message)
        {
        }

        /// <summary>
        /// Create a new exception with default message and a wrap inner exception.
        /// </summary>
        /// <param name="innerException"></param>
        public CalculationException(Exception innerException) : base(DefaultMessage, innerException)
        {
        }

        /// <summary>
        /// Create a new exception with user-supplied message and a wrap inner exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}