using Secao04.Entities;

namespace Secao04.Exercicios
{
    class Exercicio1
    {
        public Exercicio1()
        {
            Console.WriteLine("Informe os dados da primeira pessoa:");

            Pessoa pessoa1 = new Pessoa();
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Informe os dados da segunda pessoa:");

            Pessoa pessoa2 = new Pessoa();
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }

        }
    }
}
