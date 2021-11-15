//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.
//A seguir, calcule e mostre o valor da conta a pagar.

using System;
using System.Globalization;

namespace Logica.EstruturaCondicional
{
    class Exercicio5
    {
        public Exercicio5()
        {
            Console.WriteLine("Informe os dados do pedido conforme o cardápio");
            Console.WriteLine();
            Console.WriteLine("CÓDIGO------ESPECIFICAÇÃO-----------PREÇO");
            Console.WriteLine("1-----------Cachorro Quente--------R$ 4.00");
            Console.WriteLine("2-----------X-Salada---------------R$ 4.50");
            Console.WriteLine("3-----------X-Bacon----------------R$ 5.00");
            Console.WriteLine("4-----------Torrada simples--------R$ 2.00");
            Console.WriteLine("5-----------Refrigerante-----------R$ 1.50");
            Console.WriteLine();
            Console.Write("Código do item e a quantidade: ");
            string[] vect = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vect[0]);
            int quantidade = int.Parse(vect[1]);
            double total;

            Console.WriteLine();

            switch (codigo)
            {
                case 1:
                    total = quantidade * 4.00; //Cachorro Quente
                    break;
                case 2:
                    total = quantidade * 4.50; //X-Salada
                    break;
                case 3:
                    total = quantidade * 5.00; //X-Bacon
                    break;
                case 4:
                    total = quantidade * 2.00; //Torrada simples
                    break;
                case 5:
                    total = quantidade * 1.50; //Refrigerante
                    break;
                default:
                    total = 0;
                    Console.WriteLine("Opção informada inválida");
                    break;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
