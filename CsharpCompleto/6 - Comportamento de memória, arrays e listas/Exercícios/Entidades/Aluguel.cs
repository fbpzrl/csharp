namespace Secao06.Exercicios.Entidades
{
    class Aluguel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int NumeroQuarto { get; set; }

        public Aluguel(string nome, string email, int numeroQuarto)
        {
            Nome = nome;
            Email = email;
            NumeroQuarto = numeroQuarto;
        }

        public override string ToString()
        {
            return NumeroQuarto + ": " + Nome + ", " + Email;
        }
    }
}
