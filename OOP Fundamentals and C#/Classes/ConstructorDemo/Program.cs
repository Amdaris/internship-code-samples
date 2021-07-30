using System;

namespace ConstructorDemo
{
    class User
    {
        // different access modifiers
        // readonly
        // const
        private string name;
        private int balance = 10;

        public User(string name)
        {
            this.name = name;
        }

        public User(string name, int balance) : this(name)
        {
            this.balance = balance;
        }

        public int Balance => this.balance;
        public string Name => this.name;

        public void Withdraw(int amount)
        {
            balance = balance - amount;
        }

        public bool CanWithdraw(int amount)
        {
            return balance > amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", 20);
            Console.WriteLine(user.Balance);
            Console.WriteLine(user.Name);
        }
    }
}
