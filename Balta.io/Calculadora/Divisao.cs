

namespace Calculadora
{
    class Divisao
    {
        public Divisao()
        {
            Console.WriteLine("DIVISÃO");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"O resultado da divisão é: {n1 / n2}");

            Console.ReadKey();

            new Menu();
        }
    }
}
