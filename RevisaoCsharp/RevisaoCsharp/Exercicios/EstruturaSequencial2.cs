//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
//casas decimais conforme exemplos.

using System.Globalization;

namespace Secao03.Exercicios
{
    class EstruturaSequencial2
    {
        public EstruturaSequencial2()
        {
            double Pi = 3.14159;

            Console.Write("Informe o valor do raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor da área do círculo é " + (Pi * Math.Pow(raio, 2)).ToString("F4", CultureInfo.InvariantCulture) + ".");
        }
    }
}
