using System;
using System.Globalization;

namespace cond08_temperatura {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            char temperatura;
            double fahrenheit, celsius;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            temperatura = char.Parse(Console.ReadLine());
            
            if (temperatura == 'F') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                fahrenheit = double.Parse(Console.ReadLine(), CI);
                celsius = (double)5 / 9 * (fahrenheit - 32);
                Console.WriteLine("Temperatura equivalente em Celsius: " + celsius.ToString("F2", CI));
            }
            else if (temperatura == 'C') {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CI);
                fahrenheit = (double)9 * celsius / 5 + 32;
                Console.WriteLine("Temperatura equivalente em Fahrenheit: " + fahrenheit.ToString("F2", CI));
            }

        }
    }
}
