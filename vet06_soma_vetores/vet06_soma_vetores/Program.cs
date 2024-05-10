using System;

namespace vet06_soma_vetores {
    internal class Program {
        static void Main(string[] args) {

            int N;

            Console.Write("Quantos valores vai ter cada vetor? ");
            N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] soma = new int[N];

            Console.WriteLine("Digite os valores do vetor A:");
            for (int i = 0; i < N; i++) {                
                A[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (int i = 0; i < N; i++) {                
                B[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N; i++) {
                soma[i] = A[i] + B[i];                
            }

            Console.WriteLine("VETOR RESULTANTE:");
            for (int i = 0; i < N; i++) {
                Console.WriteLine(soma[i]);
            }
        }
    }
}
