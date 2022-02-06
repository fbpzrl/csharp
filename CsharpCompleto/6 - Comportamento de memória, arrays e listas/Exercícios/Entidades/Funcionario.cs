

using System.Globalization;

namespace Secao06.Exercicios.Entidades
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void aumentarSalario(double porcentagem)
        {
            double aumento = Salario * porcentagem / 100;
            Salario += aumento; 
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}