

namespace Secao06.Exercicios
{
    class ExercicioFixacao3
    {
        public ExercicioFixacao3()
        {
            Console.Write("Informe a quantidade de linhas e colunas da matriz: ");
            string[] linhasColunas = Console.ReadLine().Split(" ");
            int m = int.Parse(linhasColunas[0]);
            int n = int.Parse(linhasColunas[1]);

            int[,] mat = new int[m, n];

            Console.WriteLine();

            Console.WriteLine($"Informe os números da matriz {m} x {n}:");
            for (int i = 0; i < m; i++)
            {
                string[] entrada = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(entrada[j]);
                }
            }

            Console.WriteLine();

            Console.Write("Informe um elemento da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição [{i},{j}]:");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }

                        if (j + 1 < n)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }

                        if (i + 1 < m)
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
