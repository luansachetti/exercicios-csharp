using System;

namespace mat06_acima_diagonal {
    internal class Program {
        static void Main(string[] args) {

            int N, somaAcima;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            somaAcima = 0;
            for (int i = 0; i < N; i++) {
                for (int j = i+1; j < N; j++) {
                    somaAcima = somaAcima + mat[i, j];
                }
            }

            Console.Write("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = " + somaAcima);

        }
    }
}
