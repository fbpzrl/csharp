using System.Globalization;

namespace Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double aumento = Salario * (porcentagem / 100);
            Salario = SalarioLiquido() + aumento;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
