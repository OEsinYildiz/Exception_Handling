using System;

namespace Exception_Handling_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(HandlerException);
            int num1 = 10;
            int num2 = 0;
            string operation = Console.ReadLine();
            //operation = null;
            Calculator calculator = new Calculator();
            //catch blockları özelden genele doğru olmalıdır.
            
            /*
             * En önemli kısım burası kanka.
             * Try içerisine yazılan metot Calculator içerisinden bir ex fırlattı.
             * Fırlatılan ex türüne göre catch içerisinde yakalandı.
             * Diğer bir ayrıntı ex'ler özelden genele doğru sıralanmalıdır.
             */
            try
            {
                int result = calculator.Calculate(num1, num2, operation);
                Console.WriteLine(result);
            }
            catch (ArgumentNullException e) when (e.ParamName == nameof(operation))
            {
                Console.WriteLine("Filter exception yakalandı.");
                Console.WriteLine(e);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }
            catch (CalculationOperationNotSupportedException e)
            {
                Console.WriteLine($"CalculationOperationNotSupportedException caught {e.Operation}");
                //Aşağıdaki satır ToString'i çağırır çünki cw içerisine yazılan herşey stringe dönüşmelidir.
                Console.WriteLine(e);
            }
            catch (CalculationException e)
            {
                Console.WriteLine($"CalculationException caught");
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        private static void HandlerException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine($"There is a problem Houston. {e.ExceptionObject}");
        }
    }

    
}