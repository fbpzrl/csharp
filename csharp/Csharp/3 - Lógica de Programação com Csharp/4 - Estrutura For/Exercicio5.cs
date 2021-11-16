/*
Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.
*/

using System;

namespace Logica.EstruturaFor
{
    class Exercicio5
    {
        public Exercicio5()
        {
            Console.Write("Informe um número para descobrir seu Fatorial: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = 1;

            if (numero <= 1)
            {
                Console.WriteLine("Fatorial = 1");
            }
            else
            {
                for (int i = 0; i < numero; i++)
                {
                    fatorial *= i + 1;
                }

                Console.WriteLine("Fatorial = " + fatorial);
            }
        }
    }
}
