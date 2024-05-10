using System;

namespace rep_for04_dentro_fora {
    internal class Program {
        static void Main(string[] args) {

            int N, x, dentro, fora;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            dentro = 0;
            fora = 0;

            for (int i = 1; i <= N; i++) {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 20) {
                    fora++;
                }
                else {
                    dentro++;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");

        }
    }
}
