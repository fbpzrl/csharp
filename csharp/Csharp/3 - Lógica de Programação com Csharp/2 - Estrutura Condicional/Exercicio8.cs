/*
Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
duas casas decimais
*/
using System;
using System.Globalization;

namespace Logica.EstruturaCondicional
{
    class Exercicio8
    {
        public Exercicio8()
        {
            Console.Write("Informe o salário de uma pessoa: ");
            double imposto, excedente1 = 0, excedente2 = 0, excedente3 = 0, 
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();


            /*
             * Para atender aos requisitos do exercício, é necessário particionar a variável salario
             * de acordo com as faixas salariais. 
             * Quando o salário é <= 2000.00 , ele é isento. Por isso, não é necessário particioná-lo.
             * Quando o salário é > 2000.00 e <= 3000.00 , o salário excede apenas uma faixa.
             * Quando o salário é > 3000.00 e <= 4500.00 , o salário excede duas faixas.
             * Quando o salário é > 4500.00 , o salário excede três faixas.
            */
            if (salario <= 2000.00)
            {
                imposto = 0;
            }
            else if ((salario > 2000.00) && (salario <= 3000.00)) //imposto de 8%
            {
                excedente1 = (salario - 2000.00) * 0.08;
                imposto = excedente1;
            }
            else if ((salario > 3000.00) && (salario <= 4500.00)) //imposto de 18%
            {
                excedente1 = salario - 3000.00;
                excedente2 = salario - 2000.00 - excedente1;
                excedente1 *= 0.18;
                excedente2 *= 0.08;
                imposto = excedente1 + excedente2;
            }
            else //imposto de 28%
            {
                excedente1 = salario - 4500.00;
                excedente2 = salario - 3000.00 - excedente1;
                excedente3 = salario - 2000.00 - excedente1 - excedente2;
                excedente1 *= 0.28;
                excedente2 *= 0.18;
                excedente3 *= 0.08;
                imposto = excedente1 + excedente2 + excedente3;
            }

            if (imposto == 0)
            {
                Console.WriteLine("Imposto: Isento");
            }
            else
            {
                Console.WriteLine("Imposto: R$ {0}", imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
