using System.Globalization;
using Secao11.Entities;
using Secao11.Entities.Exceptions;

namespace Secao11.Exercicios
{
	public class ExercicioProposto_Excecoes
	{
		public ExercicioProposto_Excecoes()
		{
			try
			{
				Console.WriteLine("Enter account data");
				Console.Write("Number: ");
				int number = int.Parse(Console.ReadLine());
				Console.Write("Holder: ");
				string holder = Console.ReadLine();
				Console.Write("Initial balance: ");
				double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.Write("Withdraw limit: ");
				double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				Account account = new Account(number, holder, balance, withdrawLimit);

				Console.WriteLine();

				Console.Write("Enter amount for withdraw: ");
				double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				account.withdraw(amount);
				Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
			}
			catch (DomainException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}

