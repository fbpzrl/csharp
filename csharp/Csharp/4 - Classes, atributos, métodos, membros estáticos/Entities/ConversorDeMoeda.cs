

namespace Entities
{
    class ConversorDeMoeda
    {
        public static double Iof = 1.06; //1.06 = Acréscimo de 6% de IOF
        public static double CalcularValorPago (double cotacaoMoeda, double quantidadeMoeda)
        {
            return cotacaoMoeda * Iof * quantidadeMoeda; 
        }
    }
}
