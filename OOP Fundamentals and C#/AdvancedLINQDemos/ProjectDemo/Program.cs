using System;
using System.IO;
using System.Linq;

namespace ProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = File.ReadAllText("Burse.txt")
                .Trim()
                .Split(Environment.NewLine)
                .Select(line => line.Trim())
                .Select(line => Student.ParseStudent(line));

            students.ToList().ForEach(Console.WriteLine);
        }
    }
}
