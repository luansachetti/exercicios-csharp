using System;
using System.Globalization;

namespace seq04_soma {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y, soma;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("SOMA = " + soma);

        }
    }
}
