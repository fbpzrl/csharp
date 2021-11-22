

namespace Entities
{
     class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularNotaFinal (double nota1, double nota2, double nota3)
        {
            return nota1 + nota2 + nota3;
        }

        public bool VerificarAprovacao (double notaFinal)
        {
            if (notaFinal < 60)
            {
                return false;
            }

            return true;
        }

        public double CalcularPontosRestantes (double notaFinal)
        {
            return 60 - notaFinal;
        }
    }
}
