using System;
using System.Globalization;

namespace vet05_maior_posicao {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, posMaior;
            double maior;

            Console.Write("Quantos numeros voce vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for (int i = 0; i < N; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            posMaior = 0;
            maior = vet[0];
            for (int i = 1; i < N; i++) {
                if (maior < vet[i]) {
                    maior = vet[i];
                    posMaior = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " + maior.ToString("F2", CI));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posMaior);

        }
    }
}
