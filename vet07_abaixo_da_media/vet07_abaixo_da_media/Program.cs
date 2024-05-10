using System;
using System.Globalization;

namespace vet07_abaixo_da_media {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double soma, media;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];            

            for (int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            soma = 0;
            for (int i = 0; i < N; i++) {
                soma = soma + vet[i];
            }

            media = (double)soma / N;

            Console.WriteLine();
            Console.WriteLine("MEDIA DO VETOR = " + media.ToString("F3", CI));

            Console.WriteLine("ELEMENTOS ABAIXO DA MEDIA:");

            for (int i = 0; i < N; i++) {
                if (vet[i] < media) {
                    Console.WriteLine(vet[i].ToString("F1", CI));
                }
            }
        }
    }
}
