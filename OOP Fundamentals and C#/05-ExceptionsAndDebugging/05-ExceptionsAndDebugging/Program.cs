using System;
using System.IO;

namespace _05_ExceptionsAndDebugging
{
    public class Program
    {
        static void Main(string[] args)
        {
            //4
            try
            {
                var result = Divide1(2, 0);
            }
            catch (ArithmeticException exception)
            {
                Log(exception);

                // throw exception; NEVER DO THIS! stack trace will be lost
                
                // throw;  this keeps the stack trace

                throw new ExceptionA("Exception is now an inner exception", exception); // this wraps the initial exception in an inner exception
            }
            catch (Exception ex)
            {
                Log(ex);
                throw;
            }
        }

        private static void Log(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public static double Divide1(int divider, int divisor)
        {
            if (divisor == 0)
                throw new ArithmeticException("Attempted to divide by 0");

            var result = divider / divisor;

            return result;
        }

        public void Save2(User user)
        {
            if (user == null)
                throw new ArgumentNullException("User is null");

            // More code
        }

        public void ExceptionsExample3()
        {
            try
            {
                // some code here
            }
            catch (ExceptionA exception)
            {
                // handle exception of type ExceptionA
            }
            catch (ExceptionB exception)
            {
                // handle exception of type ExceptionB
            }
            finally
            {
                // clean up code
            }
        }

        public void Finally5()
        {
            /// v1
            Stream file = null;

            try
            {
                file = File.Open("my file name", FileMode.Append);
                //do something
            }
            finally
            {
                if (file != null)
                    file.Dispose();
            }


            /// v2
            using (var file2 = File.Open("", FileMode.Create))
            {
                // do something
            }


            /// v3
            using var file3 = File.Open("", FileMode.Create);
            // do something

        }
    }
}