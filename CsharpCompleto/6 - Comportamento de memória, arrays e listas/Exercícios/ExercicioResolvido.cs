

namespace Secao06.Exercicios
{
    class ExercicioResolvido
    {
        public ExercicioResolvido()
        {
            Console.Write("Informe um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            int[] diagonal = new int[n];
            int negativos = 0;

            int[,] mat = new int[n, n];


            Console.WriteLine("Digite os valores da matriz:");
            for (int i = 0; i < n; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(entrada[j]);

                    if (i == j)
                    {
                        diagonal[i] = mat[i, j];
                    }

                    if (mat[i, j] < 0)
                    {
                        negativos++;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < diagonal.Length; i++)
            {
                Console.Write(diagonal[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Números negativos = " + negativos);

            Console.WriteLine();
        }
    }
}
