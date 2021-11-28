
namespace Entities
{
    class Retangulo
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return Largura * 2 + Altura * 2;
        }

        public double Diagonal()
        {
            double diagonal;

            diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));

            return diagonal;
        }
    }
}
