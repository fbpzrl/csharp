/*
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo
 */

using System;

namespace Logica.EstruturaWhile
{
    class Exercicio3
    {
        public Exercicio3() 
        {
            Console.WriteLine("Informe uma das opções abaixo");
            Console.WriteLine("CÓDIGO------------TIPO");
            Console.WriteLine("--1----------------ÁLCOOL");
            Console.WriteLine("--2----------------GASOLINA");
            Console.WriteLine("--3----------------DIESEL");
            Console.WriteLine("--4----------------FIM");
            int alcool = 0, gasolina = 0, diesel = 0, escolha = int.Parse(Console.ReadLine());


            while (escolha != 4)
            {
                if ((escolha == 1) || (escolha == 2) || (escolha == 3))
                {
                    while ((escolha == 1) || (escolha == 2) || (escolha == 3))
                    {
                        if (escolha == 1)
                        {
                            alcool++;
                        }
                        else if (escolha == 2)
                        {
                            gasolina++;
                        }
                        else if (escolha == 3)
                        {
                            diesel++;
                        }

                        Console.Write("Deseja continuar? Informe outra opção: ");
                        escolha = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    while ((escolha != 1)  && (escolha != 2) && (escolha != 3) && (escolha != 4))
                    {
                        Console.Write("Informe uma opção válida (1 a 4): ");
                        escolha = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();

            if (escolha == 4)
            {
                Console.WriteLine("MUITO OBRIGADO");
                Console.WriteLine("Álcool: {0}", alcool);
                Console.WriteLine("Gasolina: {0}", gasolina);
                Console.WriteLine("Diesel: {0}", diesel);
            }
         }
     }
 }