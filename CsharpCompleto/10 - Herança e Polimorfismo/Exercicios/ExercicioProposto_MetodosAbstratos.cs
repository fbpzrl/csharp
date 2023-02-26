using System;
using System.Globalization;
using Secao10.Entities;
namespace Secao10.Exercicios
{
	public class ExercicioProposto_MetodosAbstratos
	{
		public ExercicioProposto_MetodosAbstratos()
		{
			List<Contributor> contributor = new List<Contributor>();

			Console.Write("Enter the number of contributors: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("Contributor #" + (i + 1));
				Console.Write("Individual or Company (i / c)? ");
				char type = char.Parse(Console.ReadLine().ToLower());
				Console.Write("Name: ");
				string name = Console.ReadLine();
				Console.Write("Annual Income: ");
				double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				double healthExpenses = 0.0;
                if (type == 'i')
				{
					Console.Write("Health Expenses: ");
					healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					contributor.Add(new NaturalPerson(name, annualIncome, healthExpenses));
                }
				else
				{
					Console.Write("Number of employees: ");
					int employees = int.Parse(Console.ReadLine());
					contributor.Add(new LegalPerson(name, annualIncome, employees));
				}

				Console.WriteLine();
			}

			double totalTaxes = 0.0;

			Console.WriteLine("-------");
			Console.WriteLine("TOTAL PAID");
			foreach(Contributor obj in contributor)
			{
				Console.WriteLine(obj);
				totalTaxes += obj.TotalTaxes(obj.AnnualIncome);
			}

			Console.WriteLine();

			Console.Write("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}

