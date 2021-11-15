using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.EstruturaCondicional
{
    class Exercicio3
    {
        public Exercicio3()
        {
            Console.Write("Digite dois valores inteiros: ");
            string[] vect = Console.ReadLine().Split(' ');
            int x = int.Parse(vect[0]);
            int y = int.Parse(vect[1]);

            int maior = x; 
            int menor = y;

            if (x > y)
            {
                maior = x;
                menor = y;
            }
            else
            {
                maior = y;
                menor = x;
            }

            if (menor == 0)
            {
                Console.WriteLine("Não é permitida divisão por zero");
            }
            else if (maior % menor == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são Múltiplos");
            }
        }
    }
}
