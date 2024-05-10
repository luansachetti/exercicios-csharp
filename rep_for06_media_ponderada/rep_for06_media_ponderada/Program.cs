using System;
using System.Globalization;

namespace rep_for06_media_ponderada {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, peso1, peso2, peso3, somaPesos;
            double valor1, valor2, valor3, somaValores, media;

            Console.Write("Quantos casos voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            somaPesos = 0;
            somaValores = 0;
            peso1 = 2;
            peso2 = 3;
            peso3 = 5;

            for (int i = 1; i <= N; i++) {
                somaPesos = peso1 + peso2 + peso3;

                Console.WriteLine("Digite tres numeros:");
                valor1 = double.Parse(Console.ReadLine(), CI);
                valor2 = double.Parse(Console.ReadLine(), CI);
                valor3 = double.Parse(Console.ReadLine(), CI);

                somaValores = (valor1 * peso1) + (valor2 * peso2) + (valor3 * peso3);
                media = (double)somaValores / somaPesos;

                Console.WriteLine("MEDIA = " + media.ToString("F1", CI));
            }                      

        }
    }
}
