using System.Globalization;

namespace Secao05.Entities
{
    class Conta
    {
        private int _numeroConta;
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numeroConta, string nome, double depositoInicial)
        {
            SetNumeroConta(numeroConta);
            Nome = nome;
            Saldo = depositoInicial;
        }

        //Sobrecarga do construtor, sem depósito inicial
        public Conta(int numeroConta, string nome)
        {
            SetNumeroConta(numeroConta);
            Nome = nome;
            Saldo = 0.00;
        }

        public int NumeroConta()
        {
            return _numeroConta;
        }

        public void SetNumeroConta(int numeroConta)
        {
            if (numeroConta != _numeroConta)
            {
                _numeroConta = numeroConta;
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta() + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
