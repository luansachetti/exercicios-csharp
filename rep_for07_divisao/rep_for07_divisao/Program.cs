using System;
using System.Globalization;

namespace rep_for07_divisao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, numerador, denominador;
            double resultado;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.Write("Entre com o numerador: ");
                numerador = int.Parse(Console.ReadLine());
                Console.Write("Entre com o denominador: ");
                denominador = int.Parse(Console.ReadLine());

                if (denominador == 0) {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else {
                    resultado = (double)numerador / denominador;
                    Console.WriteLine("DIVISAO = " + resultado.ToString("F2", CI));
                }
            }
        }
    }
}
