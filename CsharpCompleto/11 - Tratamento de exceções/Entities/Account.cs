using Secao11.Entities.Exceptions;

namespace Secao11.Entities
{
	public class Account
	{
		public int Number { get; set; }
		public string Holder { get; set; }
		public double Balance { get; private set; }
		public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void deposit(double amount)
        {
            Balance += amount;
        }

        public void withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}

