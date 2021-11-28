/*
Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.
*/

using System.Globalization;
using Entities;

namespace Membros_Estaticos
{
    class ExercicioFixacao
    {
        public ExercicioFixacao()
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoMoeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidadeMoeda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.Write("Valor a ser pago em reais = {0}", ConversorDeMoeda.CalcularValorPago(cotacaoMoeda, quantidadeMoeda).ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}
