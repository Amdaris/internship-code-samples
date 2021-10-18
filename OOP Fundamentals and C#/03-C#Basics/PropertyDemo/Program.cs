using System;

namespace PropertyDemo
{
    class User
    {
        private string firstName;
        private string name;
        public User(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string AddressingFormula => $"Mr. {Name}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John");
            Console.WriteLine(user.AddressingFormula);
        }
    }
}
