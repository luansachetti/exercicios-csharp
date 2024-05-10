 using System;
using System.Globalization;

namespace rep_while02_media_idades {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, cont, soma;
            double media;

            cont = 0;
            soma = 0;

            Console.WriteLine("Digite as idades:");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0) {                
                cont++;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }

            if (cont == 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {
                media = (double)soma / cont;
                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }

        }
    }
}
