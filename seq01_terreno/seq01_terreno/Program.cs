using System;
using System.Globalization;

namespace seq01_terreno {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, vlrMetroQuad, area, precoTerreno;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite o valor do metro quadrado: ");
            vlrMetroQuad = double.Parse(Console.ReadLine(), CI);

            area = largura * comprimento;
            precoTerreno = area * vlrMetroQuad;

            Console.WriteLine("Area do terreno: " + area.ToString("F2", CI));
            Console.WriteLine("Preco do terreno: " + precoTerreno.ToString("F2", CI));

        }
    }
}
