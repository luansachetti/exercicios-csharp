using System;
using System.Globalization;

namespace cond03_menor_de_tres {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c;

            Console.Write("Primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c) {
                Console.WriteLine("MENOR = " + a);
            }
            else if (b < a && b < c) {
                Console.WriteLine("MENOR = " + b);
            }
            else {
                Console.WriteLine("MENOR = " + c);
            }

        }
    }
}
