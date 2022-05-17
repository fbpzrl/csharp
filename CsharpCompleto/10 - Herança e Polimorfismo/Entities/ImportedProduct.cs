
using System.Globalization;

namespace Secao10.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
            Name = name;
            Price = price;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
