using System;

namespace Exception_Handling_Demo
{
    public class Calculator
    {
        #region Switch Kullanımı

        /*public int Calculate(int num1, int num2, string operation) => operation switch
        {
            "/" => Divide(num1, num2),
            "+" => Add(num1, num2),
            null => throw new ArgumentNullException(),
            _ => throw new ArgumentOutOfRangeException()
        };*/

        #endregion

        public int Calculate(int num1, int num2, string operation)
        {
            string nonNullOperatin = operation ?? throw new ArgumentNullException();
            if (nonNullOperatin == "/")
            {
                try
                {
                    return Divide(num1, num2);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("Sıfıra bolmek yok kanka!!!");
                    throw new CalculationException(e);
                }
            }
            else
            {
                //throw new ArgumentOutOfRangeException(nameof(operation));
                throw new CalculationOperationNotSupportedException(nonNullOperatin);
            }
        }

        private int Divide(int num1, int num2)
        {
            return num1 / num2;
            
            try
            {
                return num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Sıfıra bölemezsin");
                //Console.WriteLine(e);
                // stack trace information korumanın yolu bu.
                //throw;
                // throw e => yaparsan stack trace bozulmuş olur. 

                //Bir exception başka tür ile sarıp ekrana öyle gönderdik.
                // throw new ArithmeticException("Bir hata oluştu kanka", e);
                throw new CalculationOperationNotSupportedException();
            }
        }

        /*private int Add(int num1, int num2) => num1 + num2;*/
    }
}