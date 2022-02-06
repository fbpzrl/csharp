using Secao06.Exercicios.Entidades;

namespace Secao06.Exercicios
{
    class ExercicioFixacao1
    {
        public ExercicioFixacao1()
        {
            Aluguel[] aluguel = new Aluguel[10];

            Console.Write("Informe o número de estudantes que vão alugar quartos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                Console.WriteLine("Aluguel #" + (i + 1) + ":");
                Console.Write("Informe o nome do estudante: ");
                string nome = Console.ReadLine();

                Console.Write("Informe o e-mail do estudante: ");
                string email = Console.ReadLine();

                Console.Write("Informe o número do quarto a ser alugado: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                aluguel[numeroQuarto] = new Aluguel(nome, email, numeroQuarto);

            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");
            foreach (Aluguel obj in aluguel)
            {
                if (obj != null)
                {
                    Console.WriteLine(obj);
                }
            }
        }
    }
}
