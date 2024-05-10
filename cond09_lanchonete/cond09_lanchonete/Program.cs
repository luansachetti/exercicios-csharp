using System;
using System.Globalization;

namespace cond09_lanchonete {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo, quantidade;
            double valorPagar = 0;

            Console.Write("Codigo do produto: ");
            codigo = int.Parse(Console.ReadLine());
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            if (codigo == 1) {
                valorPagar = (double)quantidade * 5.00;
            }
            else if (codigo == 2) {
                valorPagar = (double)quantidade * 3.50;
            }
            else if (codigo == 3) {
                valorPagar = (double)quantidade * 4.80;
            }
            else if (codigo == 4) {
                valorPagar = (double)quantidade * 8.90;
            }
            else if (codigo == 5) {
                valorPagar = (double)quantidade * 7.32;
            }

            Console.WriteLine("Valor a pagar: R$ " + valorPagar.ToString("F2", CI));

        }
    }
}
