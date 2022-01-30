

namespace Calculadora
{
    class Subtracao
    {
        public Subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO");

            Console.Write("Digite o primeiro número: ");
            float n1 = float.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            float n2 = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"O resultado da subtração é: {n1 - n2}");

            Console.ReadKey();

            new Menu();
        }
    }
}