using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Menu
    {
        public Menu()
        {
            Console.WriteLine();

            Console.WriteLine("Bem-vindo ao App Calculadora !");
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair ");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcao)
            {
                case 1: new Soma(); break;
                case 2: new Subtracao(); break;
                case 3: new Divisao(); break;
                case 4: new Multiplicacao(); break;
                default: System.Environment.Exit(0); break;
            }
        }
    }
}
