/*
Ler um número inteiro N e calcular todos os seus divisores.
*/

using System;

namespace Logica.EstruturaFor
{
    class Exercicio6
    {
        public Exercicio6()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Divisores: ");

            for (int i = 0; i < numero; i++)
            {
                if (numero % (numero - i) == 0)
                {
                    Console.Write(numero / (numero - i) + " "); //exibição dos divisores em ordem crescente
                }
            }

            Console.WriteLine();
        }
    }
}
