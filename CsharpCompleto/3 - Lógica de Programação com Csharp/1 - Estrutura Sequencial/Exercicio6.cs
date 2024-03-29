﻿/* 
 * Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
mostre: 
a) a área do triângulo retângulo que tem A por base e C por altura. 
b) a área do círculo de raio C. (pi = 3.14159) 
c) a área do trapézio que tem A e B por bases e C por altura. 
d) a área do quadrado que tem lado B. 
e) a área do retângulo que tem lados A e B.
*/

using System;
using System.Globalization;

namespace Logica.EstruturaSequencial
{
    class Exercicio6
    {
        public Exercicio6()
        {
            Console.Write("Informe três valores: ");
            string[] vect = Console.ReadLine().Split(' ');
            double a = double.Parse(vect[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vect[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vect[2], CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double areaTriangulo = a * c / 2; //a = base | c = altura
            double areaCirculo = pi * Math.Pow(c, 2); //c = raio
            double areaTrapezio =  (a + b) * c / 2; //a = base maior | b = base menor | c = altura
            double areaQuadrado = Math.Pow(b, 2); //b = lado
            double areaRetangulo = a * b; //a = lado 1 | b = lado 2

            Console.WriteLine();

            Console.WriteLine("ÁREA DO TRIÂNGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO CÍRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO TRAPÉZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DO RETÂNGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
