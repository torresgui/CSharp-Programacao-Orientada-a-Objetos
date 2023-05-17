using Exercicio1;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler os valores da largura e altura de um retângulo.
            // Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e Altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("AREA = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}