//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
//mensagem explicativa, conforme exemplos.

namespace Secao03.Exercicios
{
    class EstruturaSequencial1
    {
        public EstruturaSequencial1()
        {
            Console.Write("Informe o primeiro valor inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("SOMA = " + (num1 + num2));
        }

    }
}
