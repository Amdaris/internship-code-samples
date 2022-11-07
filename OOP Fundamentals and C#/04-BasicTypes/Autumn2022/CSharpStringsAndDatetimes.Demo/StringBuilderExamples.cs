using System.Text;

namespace CSharpStringsAndDatetimes.Demo
{
    internal static class StringBuilderExamples
    {
        internal static void ShowExamples()
        {
            Console.WriteLine();
            Console.WriteLine("StringBuilder Demo:");
            StringBuilder builder = new("Today", 100);

            builder.Append(" is ");

            builder.AppendFormat("{0} - {1:hh:mm}", DateTime.Now.DayOfWeek, DateTime.Now);

            Console.WriteLine($"{builder.Length} characters: {builder.ToString()}");

            builder.Insert(0, "Hello, ");

            builder.Replace("l", "L");

            Console.WriteLine($"{builder.Length} characters: {builder.ToString()}");
        }
    }
}
