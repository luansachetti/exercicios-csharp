using System;
using System.Globalization;
using System.Xml;

namespace vet11_dados_pessoais {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, contAltMulheres, numeroHomens;
            double menorAltura, maiorAltura, somaAltMulheres, mediaAltMulheres;

            Console.Write("Quantas pessoas serao digitadas? ");
            N = int.Parse(Console.ReadLine());

            double[] alturas = new double[N];
            char[] generos = new char[N];

            for (int i = 0; i < N; i++) {
                Console.Write("Altura da " + (i + 1) + "a pessoa: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Genero da " + (i + 1) + "a pessoa: ");
                generos[i] = char.Parse(Console.ReadLine());
            }

            menorAltura = alturas[0];
            for (int i = 1; i < N; i++) {
                if (menorAltura > alturas[i]) {
                    menorAltura = alturas[i];
                }
            }
            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CI));

            maiorAltura = alturas[0];
            for (int i = 1; i < N; i++) {
                if (maiorAltura < alturas[i]) {
                    maiorAltura = alturas[i];
                }
            }
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CI));

            somaAltMulheres = 0;
            contAltMulheres = 0;
            for (int i = 0; i < N; i++) {
                if (generos[i] == 'F') {
                    somaAltMulheres = somaAltMulheres + alturas[i];
                    contAltMulheres++;
                }
            }
            mediaAltMulheres = somaAltMulheres / contAltMulheres;
            Console.WriteLine("Media das alturas da mulheres = " + mediaAltMulheres.ToString("F2", CI));

            numeroHomens = N - contAltMulheres;

            Console.WriteLine("Numero de homens = " + numeroHomens);      
            

        }
    }
}
