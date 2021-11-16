/*
Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste 
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes 
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem 
peso 5.
*/

using System;
using System.Globalization;

namespace Logica.EstruturaFor
{
    class Exercicio3
    {
        public Exercicio3()
        {
            Console.Write("Informe a quantidade de casos de teste: ");
            int quantidade = int.Parse(Console.ReadLine());
            string[] valores = new string[quantidade];
            double[] medias = new double[quantidade];
            double valor1, valor2, valor3;

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Informe o caso de teste #{0}: ", i + 1);
                valores = Console.ReadLine().Split(' ');
                valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                medias[i] = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / (2 + 3 + 5);
            }

            Console.WriteLine();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Média Ponderada do caso de teste #{0}: {1}", i + 1, medias[i].ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine();
            }
        }
    }
}
