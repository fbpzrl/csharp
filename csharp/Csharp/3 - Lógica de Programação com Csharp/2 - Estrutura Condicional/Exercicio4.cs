//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

using System;

namespace Logica.EstruturaCondicional
{
    class Exercicio4
    {
        public Exercicio4()
        {
            Console.Write("Informe a hora inicial e a hora final do jogo: ");
            string[] vect = Console.ReadLine().Split(' ');
            int inicio = int.Parse(vect[0]);
            int fim = int.Parse(vect[1]);

            int duracao;

            if (inicio < fim)
            {
                duracao = fim - inicio;
            }
            else
            {
                duracao = 24 - inicio + fim;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }
    }
}
