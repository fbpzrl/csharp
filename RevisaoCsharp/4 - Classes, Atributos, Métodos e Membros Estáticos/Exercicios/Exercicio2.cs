using Secao04.Entities;
using System.Globalization;

namespace Secao04.Exercicios
{
    class Exercicio2
    {
        public Exercicio2()
        {
            Console.WriteLine("Informe os dados do primeiro funcionário:");

            Funcionario funcionario1 = new Funcionario();
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Informe os dados do segundo funcionário:");

            Funcionario funcionario2 = new Funcionario();
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Salário médio = " + ((funcionario1.Salario + funcionario2.Salario) / 2).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
