using System;

namespace rep_for08_fatorial {
    internal class Program {
        static void Main(string[] args) {

            int N, fatorial;

            fatorial = 1;

            Console.Write("Digite o valor de N: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                fatorial = fatorial * i;
            }

            Console.WriteLine("FATORIAL = " + fatorial);

        }
    }
}
