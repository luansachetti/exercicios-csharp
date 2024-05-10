using System;
using System.Globalization;

namespace vet03_alturas {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;
            double somaAlturas, alturaMedia, menores, porcentagemMenores;

            Console.Write("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            int[] idades = new int[N];
            double[] alturas = new double[N];

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Dados da " + (i+1) + "a pessoa:");
                Console.Write("Nome: ");
                nomes[i] = (Console.ReadLine());
                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine());
                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
            }

            somaAlturas = 0;
            for(int i = 0; i < N; i++) {
                somaAlturas = somaAlturas + alturas[i];
            }

            alturaMedia = (double)somaAlturas / N;

            Console.WriteLine();
            Console.WriteLine("Altura media: " + alturaMedia.ToString("F2", CI));

            menores = 0;
            for (int i = 0; i < N; i++) {
                if (idades[i] < 16) {
                    menores++;
                }
            }

            porcentagemMenores = (double)menores / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagemMenores.ToString("F1", CI) + "%");
            for (int i = 0; i < N; i++) {
                if (idades[i] < 16) {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
