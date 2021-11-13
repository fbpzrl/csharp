using System;
using System.Globalization;

namespace Logica.EstruturaSequencial
{
    class Exercicio2
    {
        public Exercicio2()
        {
            double raio, area, pi = 3.14159;

            Console.Write("Digite o raio do círculo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //área do círculo: pi * (raio * raio)
            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
