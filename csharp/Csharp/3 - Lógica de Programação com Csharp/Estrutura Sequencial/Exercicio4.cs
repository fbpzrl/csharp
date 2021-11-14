using System;
using System.Globalization;

namespace Logica.EstruturaSequencial
{
    class Exercicio4
    {
        public Exercicio4()
        {
            Console.WriteLine("Informe os seguintes valores:");
            Console.WriteLine("Número do Funcionário | Horas Trabalhadas | Valor da Hora");
            string[] vect = Console.ReadLine().Split(' ');
            int numeroFuncionario = int.Parse(vect[0]);
            int horasTrabalhadas = int.Parse(vect[1]);
            double valorHora = double.Parse(vect[2], CultureInfo.InvariantCulture);

            double salario = horasTrabalhadas * valorHora;

            Console.WriteLine();
            Console.WriteLine("NUMBER = " + numeroFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
