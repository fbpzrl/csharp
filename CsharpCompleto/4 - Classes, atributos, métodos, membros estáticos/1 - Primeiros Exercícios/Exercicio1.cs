/*
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.
*/

using Entities;

namespace Primeiros_Exercícios
{
    class Exercicio1
    {
        public Exercicio1()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();
            string maisVelha = "";

            Console.WriteLine("Digite os dados da primeira pessoa:");

            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da segunda pessoa:");

            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.Write("Pessoa mais velha: {0}", pessoa1.Nome);
            }
            else
            {
                Console.Write("Pessoa mais velha: {0}", pessoa2.Nome);
            }
        }

    }
}
