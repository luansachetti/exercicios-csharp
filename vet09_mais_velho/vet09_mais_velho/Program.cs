using System;

namespace vet09_mais_velho {
    internal class Program {
        static void Main(string[] args) {

            int N, maisVelho, posMaisVelho;

            Console.Write("Quantas pessoas voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }

            maisVelho = idades[0];
            posMaisVelho = 0;
            for (int i = 1; i < N; i++) {
                if (maisVelho < idades[i]) {
                    maisVelho = idades[i];
                    posMaisVelho = i;
                }
            }

            Console.WriteLine("PESSOA MAIS VELHA: " + nomes[posMaisVelho]);

        }
    }
}
