/*
Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme 
exemplo.
*/

using System;

namespace Logica.EstruturaFor
{
    class Exercicio7
    {
        public Exercicio7()
        {
            Console.Write("Informe um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Número da Linha | Quadrado da Linha | Cubo da Linha");

            for (int i = 0; i < n; i++)
            {
                Console.Write("--------" + (i + 1) + "----------------" + Math.Pow(i + 1, 2) + "----------------" + Math.Pow(i + 1, 3));
                Console.WriteLine();
            }
        }
    }
}
