using System;
using System.Globalization;

namespace seq07_pagamento {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double vlrHora, pagamento;
            int hrsTrab;

            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Valor por hora: ");
            vlrHora = double.Parse(Console.ReadLine(), CI);
            Console.Write("Horas trabalhadas: ");
            hrsTrab = int.Parse(Console.ReadLine(), CI);

            pagamento = (double)vlrHora * hrsTrab;

            Console.WriteLine("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2", CI));

        }
    }
}
