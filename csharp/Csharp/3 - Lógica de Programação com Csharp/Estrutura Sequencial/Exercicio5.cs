using System;
using System.Globalization;

namespace Logica.EstruturaSequencial
{
    class Exercicio5
    {
        public Exercicio5()
        {
            Console.WriteLine("Digite os dados da Peça 1: ");
            Console.WriteLine("Código | Quantidade | Valor Unitário");
            string[] vect = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(vect[0]);
            int quantidadePeca1 = int.Parse(vect[1]);
            double valorPeca1 = double.Parse(vect[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("Digite os dados da Peça 2: ");
            Console.WriteLine("Código | Quantidade | Valor Unitário");
            string[] vect2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(vect2[0]);
            int quantidadePeca2 = int.Parse(vect2[1]);
            double valorPeca2 = double.Parse(vect2[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            double total = (valorPeca1 * quantidadePeca1) + (valorPeca2 * quantidadePeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
