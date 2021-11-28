/*
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
 */

using System;

namespace Logica.EstruturaWhile
{
    class Exercicio2
    {
        public Exercicio2()
        {
            Console.Write("Informe as coordenadas (X, Y): ");
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while ((x != 0) && (y != 0))
            {
                if ((x > 0) && (y > 0))
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if ((x < 0) && (y > 0))
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if ((x < 0) && (y < 0))
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if ((x > 0) && (y < 0))
                {
                    Console.WriteLine("Quarto Quadrante");
                }

                Console.Write("Informe novamente as coordenadas (X, Y): ");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse (valores[1]);
            }
        }
    }
}
