using System;

namespace OverloadingDemo
{
    public class EmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine("Sending email");
        }

        public void SendEmail(string to, string subject, object image)
        {
            Console.WriteLine("Sending email with image");
        }

        public void SendEmail(string to, string cc, string subject, string body)
        {
            Console.WriteLine("Sending email with cc");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail("to", "Hello", "Something here");
            emailService.SendEmail("to", "cc", "Hello", "Something here");
        }
    }
}
