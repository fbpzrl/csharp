using System;
namespace Secao10.Entities
{
	public class LegalPerson : Contributor
	{
		public int Employees { get; set; }

		public LegalPerson()
		{
		}

        public LegalPerson(string name, double annualIncome, int employees) : base(name, annualIncome)
        {
			Employees = employees;
        }

        public override double TotalTaxes(double annualIncome)
        {
            if (Employees > 10)
            {
                return annualIncome * 0.14;
            }
            else
            {
                return annualIncome * 0.16;
            }
        }
    }
}

