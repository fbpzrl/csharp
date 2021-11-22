/*
Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de
sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.
*/
using System.Globalization;
using Entities;

namespace Exercicios_Fixacao
{
    class Exercicio1
    {
        public Exercicio1()
        {
            Console.Write("Informe a largura e a altura do Retângulo: ");
            string[] valores = Console.ReadLine().Split(' ');
            Retangulo retangulo = new Retangulo();
            retangulo.Largura = double.Parse(valores[0], CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(valores[1], CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = {0}", retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO = {0}", retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = {0}", retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
        }
    }
}
