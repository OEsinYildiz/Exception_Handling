using System;

namespace Exception_Handling_Demo
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        private const string DefaultMessage = "That is a default message";

        public string Operation { get; }

        public CalculationOperationNotSupportedException() : base(DefaultMessage)
        {
        }

        public CalculationOperationNotSupportedException(Exception innerException) : base(DefaultMessage,
            innerException)
        {
        }
        
        
        public CalculationOperationNotSupportedException(string message,Exception innerException) : base(message,
            innerException)
        {
        }

        public CalculationOperationNotSupportedException(string operation) : base(DefaultMessage) =>
            Operation = operation;
        
        public CalculationOperationNotSupportedException(string operation, string message) : base(message) =>
            Operation = operation;

        public override string ToString()
        {
            if (Operation is null)
            {
                return base.ToString();
            }
            return base.ToString() + Environment.NewLine +$"Unsupported operation: {Operation}";
        }
    }
}