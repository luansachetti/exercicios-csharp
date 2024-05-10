using System;
using System.Globalization;

namespace vet08_media_pares {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, contPares, somaPares;
            double mediaPares;

            Console.Write("Quantos elementos vai ter o vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            for (int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            contPares = 0;
            somaPares = 0;

            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    somaPares = somaPares + vet[i];
                    contPares++;
                }
            }

            mediaPares = (double)somaPares / contPares;

            if (contPares == 0) {
                Console.WriteLine("NENHUM NUMERO PAR");
            }
            else {
                Console.WriteLine("MEDIA DOS PARES = " + mediaPares.ToString("F1", CI));
            }
        }
    }
}
