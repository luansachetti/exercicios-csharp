using System;

namespace rep_for01_tabuada {
    internal class Program {
        static void Main(string[] args) {

            int N, produto;

            Console.Write("Deseja a tabuada para qual numero? ");
            N = int.Parse(Console.ReadLine());

            produto = 0;
            for (int i = 1; i <= 10; i++) {
                produto = N * i;
                Console.WriteLine(N + " x " + i + " = " + produto);
            }
        }
    }
}
