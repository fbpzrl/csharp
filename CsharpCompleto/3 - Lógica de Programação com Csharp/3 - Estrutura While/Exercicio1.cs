/*
Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
*/

using System;

namespace Logica.EstruturaWhile
{
    class Exercicio1
    {
        public Exercicio1() 
        {
            int senha = 2002;

            Console.Write("Informe a senha: ");
            int entrada = int.Parse(Console.ReadLine());

            while (entrada != senha)
            {
                Console.WriteLine("Senha Inválida");
                Console.WriteLine();
                Console.WriteLine("Informe a senha novamente:");
                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
