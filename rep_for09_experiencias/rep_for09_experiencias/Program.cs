using System;
using System.Globalization;

namespace rep_for09_experiencias {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, quantidade, coelhos, ratos, sapos, totalCobaias;
            char tipoCobaia;
            double percCoelhos, percRatos, percSapos;

            Console.Write("Quantos casos de teste serao digitados: ");
            N = int.Parse(Console.ReadLine());

            coelhos = 0;
            ratos = 0;
            sapos = 0;
            totalCobaias = 0;

            for (int i = 1; i <= N; i++) {
                
                Console.Write("Quantidade de cobaias: ");
                quantidade = int.Parse(Console.ReadLine());
                Console.Write("Tipo de cobaia: ");
                tipoCobaia = char.Parse(Console.ReadLine());

                if (tipoCobaia == 'C') {
                    coelhos = coelhos + quantidade;
                }
                else if (tipoCobaia == 'R') {
                    ratos = ratos + quantidade;
                }
                else if (tipoCobaia == 'S') {
                    sapos = sapos + quantidade;
                }             

            }

            totalCobaias = coelhos + ratos + sapos;
            percCoelhos = (double)coelhos / totalCobaias * 100;
            percRatos = (double)ratos / totalCobaias * 100;
            percSapos = (double)sapos / totalCobaias * 100;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL:");
            Console.WriteLine("Total: " + totalCobaias);
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + percCoelhos.ToString("F2", CI));
            Console.WriteLine("Percentual de ratos: " + percRatos.ToString("F2", CI));
            Console.WriteLine("Percentual de sapos: " + percSapos.ToString("F2", CI));

        }
    }
}
