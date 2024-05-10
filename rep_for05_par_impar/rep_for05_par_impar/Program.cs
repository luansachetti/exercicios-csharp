using System;

namespace rep_for05_par_impar {
    internal class Program {
        static void Main(string[] args) {

            int N, x;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x < 0 && x % 2 != 0) {
                    Console.WriteLine("IMPAR NEGATIVO");
                }
                else if (x < 0 && x % 2 == 0) {
                    Console.WriteLine("PAR NEGATIVO");
                }
                else if (x > 0 && x % 2 != 0) {
                    Console.WriteLine("IMPAR POSITIVO");
                }
                else if (x > 0 && x % 2 == 0) {
                    Console.WriteLine("PAR POSITIVO");
                }
                else if (x == 0) {
                    Console.WriteLine("NULO");
                }
            }

        }
    }
}
