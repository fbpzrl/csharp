using System;

namespace Logica.EstruturaSequencial
{
    class Exercicio1
    {
        public Exercicio1() 
        {
            int valor1, valor2;

            Console.Write("Digite dois números inteiros: ");
            string[] vect = Console.ReadLine().Split(' '); //captura vários inputs separados por espaço
            valor1 = int.Parse(vect[0]);
            valor2 = int.Parse(vect[1]);

            Console.WriteLine("SOMA = " + (valor1 + valor2));
        }
    }
}
