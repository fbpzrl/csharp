
namespace Secao10.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(double additionalCharge, string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public override double Payment()
        {
            double bonus = AdditionalCharge * 1.1;
            return base.Payment() + bonus;
        }
    }
}
