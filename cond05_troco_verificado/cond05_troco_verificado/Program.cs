using System;
using System.Globalization;

namespace cond05_troco_verificado {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco, dinheiro, troco, resto;
            int quantidade;

            Console.Write("Preco unitario do produto: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            if (dinheiro >= (preco* quantidade)) {
                troco = dinheiro - preco * quantidade;
                Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
            }
            else {
                resto = preco * quantidade - dinheiro;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + resto.ToString("F2", CI) + " REAIS");
            }

        }
    }
}
