using System;
using System.Globalization;

namespace seq09_medidas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, areaQuad, areaTrian, areaTrap;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            areaQuad = Math.Pow(a, 2.0);
            areaTrian = (a * b) / 2;
            areaTrap = (a + b) * c / 2;

            Console.WriteLine("AREA DO QUADRADO = " + areaQuad.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO = " + areaTrian.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = " + areaTrap.ToString("F4", CI));

        }
    }
}
