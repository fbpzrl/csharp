/*
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o
aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este
problema
*/
using System.Globalization;
using Entities;

namespace Exercicios_Fixacao
{
    class Exercicio3
    {
        public Exercicio3()
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe os dados do aluno:");
            
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite as três notas do aluno: ");
            string[] notas = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);

            double notaFinal = aluno.CalcularNotaFinal(nota1, nota2, nota3);

            Console.WriteLine();

            Console.WriteLine("NOTA FINAL = {0}", notaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.VerificarAprovacao(notaFinal))
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", aluno.CalcularPontosRestantes(notaFinal).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
