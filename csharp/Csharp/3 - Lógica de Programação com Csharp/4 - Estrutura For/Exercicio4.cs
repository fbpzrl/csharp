/*
Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo 
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
*/

using System;
using System.Globalization;

namespace Logica.EstruturaFor
{
    class Exercicio4
    {
        public Exercicio4()
        {
            Console.Write("Informe a sequência de pares a ser avaliada: ");
            int n = int.Parse(Console.ReadLine());

            string[] pares;
            double[] divisao = new double[n];
            string[] zeros = new string[n];
            double numerador = 0, denominador = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o par #{0}: ", i + 1);
                pares = Console.ReadLine().Split(' ');
                numerador = double.Parse(pares[0], CultureInfo.InvariantCulture);
                denominador = double.Parse(pares[1], CultureInfo.InvariantCulture);

                if (denominador != 0)
                {
                    divisao[i] = numerador / denominador;
                }
                else
                {
                    zeros[i] = "Divisão Impossível";
                }
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                if (zeros[i] == null)
                {
                    Console.WriteLine("Divisão {0}", divisao[i].ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine(zeros[i]);
                }
            }
        }
    }
}
