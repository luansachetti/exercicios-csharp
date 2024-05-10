using System;
using System.ComponentModel.Design;
using System.Globalization;

namespace vet12_comerciante {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, abaixo, entre, acima;
            double totalCompra, totalVenda, lucroTotal;

            Console.Write("Serao digitados dados de quantos produtos? ");
            N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];
            double[] porcLucro = new double[N];

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Produto " + (i + 1) + ":");
                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();
                Console.Write("Preco de compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), CI);
                Console.Write("Preco de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), CI);
            }
            Console.WriteLine();

            Console.WriteLine("RELATORIO:");

            for (int i = 0; i < N; i++) {
                porcLucro[i] = (precoVenda[i] - precoCompra[i]) / precoCompra[i] * 100.00;
            }

            abaixo = 0;
            entre = 0;
            acima = 0;

            for (int i = 0; i < N; i++) {
                if (porcLucro[i] < 10.0) {
                    abaixo++;
                }
                else if (porcLucro[i] < 20.0) {
                    entre++;
                }
                else {
                    acima++;
                }
            }

            totalCompra = 0;
            totalVenda = 0;
            for (int i = 0; i < N; i++) {
                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            lucroTotal = totalVenda - totalCompra;

            Console.WriteLine("Lucro abaixo de 10%: " + abaixo);
            Console.WriteLine("Lucro entre 10% e 20%: " + entre);
            Console.WriteLine("Lucro acima de 20%: " + acima);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CI));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CI));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CI));

        }
    }
}
