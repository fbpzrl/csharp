/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/

using System;

namespace Logica.EstruturaFor
{
    class Exercicio2
    {
        public Exercicio2()
        {
            Console.Write("Informe a quantidade de números a serem avaliados: ");
            int dentro = 0, fora = 0, quantidade = int.Parse(Console.ReadLine());
            int[] numero = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite o valor #{0}: ", (i + 1));
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numero.Length; i++)
            {
                if ((numero[i] >= 10) && (numero[i] <= 20))
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine();

            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
