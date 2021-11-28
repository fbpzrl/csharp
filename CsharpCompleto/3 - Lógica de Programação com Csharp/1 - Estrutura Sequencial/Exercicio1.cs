//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
//mensagem explicativa, conforme exemplos.

using System;

namespace Logica.EstruturaSequencial
{
    class Exercicio1
    {
        public Exercicio1() 
        {

            Console.Write("Digite dois números inteiros: ");
            string[] vect = Console.ReadLine().Split(' '); //captura vários inputs separados por espaço
            int valor1 = int.Parse(vect[0]);
            int valor2 = int.Parse(vect[1]);

            Console.WriteLine("SOMA = " + (valor1 + valor2));
        }
    }
}
