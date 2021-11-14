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
