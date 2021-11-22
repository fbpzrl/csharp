/*
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.
*/

using Entities;
using System.Globalization;
using Entities;

namespace Primeiros_Exercicios
{
    class Exercicio2
    {
        public Exercicio2()
        {
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Funcionario f1 = new Funcionario();
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            Funcionario f2 = new Funcionario();
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine();

            Console.WriteLine("Salário médio = {0}", salarioMedio.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}
