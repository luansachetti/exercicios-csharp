using System;
using System.Globalization;

namespace cond04_operadora {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos;
            double valorPago;

            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            valorPago = 50.0;

            if (minutos > 100) {
                valorPago = (double)valorPago + 2 * (minutos - 100);
            }

            Console.WriteLine("Valor a pagar: R$ " + valorPago.ToString("F2", CI));

        }
    }
}
