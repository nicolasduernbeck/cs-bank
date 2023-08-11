using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("testAccount", 100);
            Console.WriteLine(account.balance);
            account.Withdraw(101);
            Console.WriteLine(account.balance);
        }
    }

    class BankAccount 
    {
        private string Name;
        private float Balance;

        public BankAccount(string name, float balance)
        {
            Name = name;
            Balance = balance;
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public float balance
        {
            get { return Balance;}
        }

        public void Deposit(float amount)
        {
            Balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount <= Balance) 
            {
                Balance -= amount;
            } else
            {
                Console.WriteLine("You dont have enough money!");
            }
        }
    }
}
