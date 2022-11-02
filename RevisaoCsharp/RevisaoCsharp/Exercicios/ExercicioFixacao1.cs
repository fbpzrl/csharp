using System.Globalization;

namespace Secao03.Exercicios
{
    internal class ExercicioFixacao1
    {
        public ExercicioFixacao1()
        {
            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine($"Nome completo: {nome}");
            Console.WriteLine($"Número de quartos: {quartos}");
            Console.WriteLine($"Preço do produto: {preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Último nome: {ultimoNome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura.ToString(CultureInfo.InvariantCulture)}");

        }
    }
}
