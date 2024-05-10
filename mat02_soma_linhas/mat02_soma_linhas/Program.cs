using System;
using System.Globalization;

namespace mat02_soma_linhas {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int M, N;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("Qual a quantidade de colunas da matriz? ");
            N = int.Parse(Console.ReadLine());

            double[,] mat = new double[M, N];
            double[] vetSoma = new double[M];

            for (int i = 0; i < M; i++) {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a linha:");
                for (int j = 0; j < N; j++) {                    
                    mat[i, j] = double.Parse(Console.ReadLine(), CI);
                }
            }            

            for (int i = 0; i < M; i++) {
                vetSoma[i] = 0;
                for (int j = 0; j < N; j++) {
                    vetSoma[i] = vetSoma[i] + mat[i, j];
                }
            }

            Console.WriteLine("VETOR GERADO:");
            for (int i = 0; i < M; i++) {
                Console.WriteLine(vetSoma[i].ToString("F1", CI));
            }

        }
    }
}
