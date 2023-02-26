using System;

namespace Secao10.Entities
{
    public class NaturalPerson : Contributor
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson()
        {
        }

        public NaturalPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double TotalTaxes(double annualIncome)
        {
            if (base.AnnualIncome <= 20000.0)
            {
                return annualIncome * 0.15 - (HealthExpenses * 0.5);
            }
            else
            {
                return annualIncome * 0.25 - (HealthExpenses * 0.5);
            }
        }
    }
}

