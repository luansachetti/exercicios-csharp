using System;

namespace mat05_soma_matrizes {
    internal class Program {
        static void Main(string[] args) {

            int M, N;

            Console.Write("Quantas linhas vai ter cada matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter cada matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] matA = new int[M, N];
            int[,] matB = new int[M, N];
            int[,] matSoma = new int[M, N];

            Console.WriteLine("Digite os valores da matriz A:");
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matA[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite os valores da matriz B:");
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    matB[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("MATRIZ SOMA:");
            for (int i = 0; i < M; i++) {                
                for (int j = 0; j < N; j++) {
                    matSoma[i, j] = matA[i, j] + matB[i, j];
                }                
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(matSoma[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
