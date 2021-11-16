/*
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o 
X, se for o caso. 
*/

using System;

namespace Logica.EstruturaFor
{
    class Exercicio1
    {
        public Exercicio1() 
        {
            Console.Write("Informe um número inteiro (entre 1 e 1000): ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0) //imprime somente os números ímpares
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
