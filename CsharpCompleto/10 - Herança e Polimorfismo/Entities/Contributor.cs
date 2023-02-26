using System;
using System.Globalization;

namespace Secao10.Entities
{
	public abstract class Contributor
	{
		public string Name { get; set; }
		public double AnnualIncome { get; set; }

		public Contributor()
		{
		}

        public Contributor(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

		public abstract double TotalTaxes(double annualIncome);

        public override string ToString()
        {
            return Name
                    + ": $ "
                    + TotalTaxes(AnnualIncome).ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

