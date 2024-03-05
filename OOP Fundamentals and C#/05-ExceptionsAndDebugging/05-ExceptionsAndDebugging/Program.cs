
#define STAGE
using System;
using System.Collections.Generic;
using System.IO;


namespace _05_ExceptionsAndDebugging
{
    public class Program
    {
        static void Main(string[] args)
        {
            //debug
            var result = CreateUsers();

#if(STAGE)
            foreach (var user in result)
            {
                Console.WriteLine(user);
            }

#endif
            // multiple catch
            PerformArithmetics();

            //finally 
            WriteToFileExample();

        }


        private static IEnumerable<User> CreateUsers()
        {
            var allUsers = new List<User>();

            var user1 = new User()
            {
                Id = 1,
                FullName = "Dave Robinson",
                Email = "dave.robinson@gmail.com",
                HomeAddress = new Address { Line1 = "Abbey Road Unit 5", City = "London"},
            };

            var user2 = new User()
            {
                Id = 2,
                FullName = "Riley Walker",
                Email = "riley.walker@gmail.com",
                HomeAddress = new Address { Line1 = "Oxford Street", City = "London" },
            };


            Save(user1);
            Save(user2);

            allUsers.Add(user1);
            allUsers.Add(user2);

            return allUsers;
        }

        public static void PerformArithmetics() 
        {
            try
            {
                var result = Divide1(2, 0);
            }
            catch (ArithmeticException exception)
            {
                Log(exception);

                // throw exception; NEVER DO THIS! stack trace will be lost

                // throw;  this keeps the stack trace

               // throw new ExceptionA("The was an error while performing arithmetics", exception); // this wraps the initial exception in an inner exception
            }
            catch (Exception ex)
            {
                Log(ex);
                throw;
            }
        }


        public static void WriteToFileExample()
        {
            /// v1
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("path_to_your_file.txt", true);

                //WriteLine(writer);
                writer.WriteLine("this might fail");


                //do something

            }
            catch (Exception ex)
            {
                // handle exception of type Exception
            }
            finally
            {
                if (writer != null)
                    writer.Dispose();
            }


            /// v2
            using (var writer2 = new StreamWriter("path_to_your_file.txt", true))
            {
                writer.WriteLine("this might fail");

                // do something
            }


            /// v3
            using var writer3 = new StreamWriter("path_to_your_file.txt", true);
            writer.WriteLine("this might fail");

            // do something

        }

        private static void WriteLine(StreamWriter writer)
        {
            throw new Exception("Error writing in the file");
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

        public static void Save(User user)
        {
            if (user == null)
                throw new ArgumentNullException("User is null");

            // More code
        }

      

       
    }
}