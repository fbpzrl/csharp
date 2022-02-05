using Secao05.Entities;
using System.Globalization;

namespace Secao05
{
    class ExercicioFixacao
    {
        public ExercicioFixacao()
        {
            Console.Write("Informe o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Informe o titular da conta: ");
            string nome = Console.ReadLine(); 
            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());
            double depositoInicial = 0;
            Conta conta;

            if (opcao == 's')
            {
                Console.Write("Informe o depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(NumeroConta, nome, depositoInicial);
            }
            else
            {
                conta = new Conta(NumeroConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe um valor de depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(deposito);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saque);
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
        }
    }
}
