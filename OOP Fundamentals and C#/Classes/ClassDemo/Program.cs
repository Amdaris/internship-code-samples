using System;

namespace ClassDemo
{
    class User
    {
        private string name;
        private int balance = 10;

        public User(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public bool TryWithdraw(int amount)
        {
            if (CanWithdraw(amount))
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public bool CanWithdraw(int amount)
        {
            return balance > amount;
        }

        public override string ToString()
        {
            return $"{name}: {balance}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("John", 100);
            bool canWithdraw = user.CanWithdraw(9);

            Console.WriteLine(canWithdraw);

            bool withdrawalSucceeded = user.TryWithdraw(900);
            if (withdrawalSucceeded)
            {
                Console.WriteLine($"User: {user}");
            }
            else
            {
                Console.WriteLine("Couldn't withdraw");
            }

            Console.WriteLine(user);
        }
    }
}
