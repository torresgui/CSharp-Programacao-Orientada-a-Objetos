using System;
using System.Globalization;

namespace Exercicio1
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double  Area()
        {
            return Largura * Altura;
        }

        public double Perimetro ()
        {
            return (Largura * 2.00) + (Altura * 2.00);
        }

        public double Diagonal ()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }

    }


}
