//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

using System;

namespace Logica.EstruturaSequencial
{
    class Exercicio3
    {
        public Exercicio3()
        {
            Console.Write("Informe quatro números inteiros: ");
            string[] vect = Console.ReadLine().Split(' ');
            int a = int.Parse(vect[0]);
            int b = int.Parse(vect[1]);
            int c = int.Parse(vect[2]);
            int d = int.Parse(vect[3]);

            Console.WriteLine("DIFERENÇA = " + (a * b - c * d));
        }
    }
}
