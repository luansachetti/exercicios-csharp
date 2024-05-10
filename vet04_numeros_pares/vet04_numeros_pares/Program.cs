using System;

namespace vet04_numeros_pares {
    internal class Program {
        static void Main(string[] args) {

            int N, qntPares;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            int[] vet = new int[N];

            for (int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("NUMEROS PARES:");
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    Console.Write(vet[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();

            qntPares = 0;
            for (int i = 0; i < N; i++) {
                if (vet[i] % 2 == 0) {
                    qntPares++;
                }
            }
            Console.WriteLine("QUANTIDADE DE PARES = " + qntPares);

        }
    }
}
