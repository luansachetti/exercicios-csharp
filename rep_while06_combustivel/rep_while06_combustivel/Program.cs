using System;
using System.Globalization;

namespace rep_while06_combustivel {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo, alcool, gasolina, diesel;

            alcool = 0;
            gasolina = 0;
            diesel = 0;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4) {
                if (codigo == 1) {
                    alcool++;
                }
                else if (codigo == 2) {
                    gasolina++;
                }
                else if (codigo == 3) {
                    diesel++;
                }
                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
