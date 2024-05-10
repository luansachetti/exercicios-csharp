using System;
using System.Globalization;

namespace seq05_troco {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco, dinheiro, troco;
            int quantidade;

            Console.Write("Preco unitario do produto: ");
            preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            troco = (double)dinheiro - (preco * quantidade);

            Console.WriteLine("TROCO = " + troco.ToString("F2", CI));

        }
    }
}
