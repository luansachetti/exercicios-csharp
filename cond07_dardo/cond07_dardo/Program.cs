using System;
using System.Globalization;

namespace cond07_dardo {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double dist1, dist2, dist3;

            Console.WriteLine("Digite as tres distancias:");
            dist1 = double.Parse(Console.ReadLine(), CI);
            dist2 = double.Parse(Console.ReadLine(), CI);
            dist3 = double.Parse(Console.ReadLine(), CI);

            if (dist1 > dist2 && dist1 > dist3) {
                Console.WriteLine("MAIOR DISTANCIA = " + dist1.ToString("F2", CI));
            }
            else if (dist2  > dist3) {
                Console.WriteLine("MAIOR DISTANCIA = " + dist2.ToString("F2", CI));
            }
            else {
                Console.WriteLine("MAIOR DISTANCIA = " + dist3.ToString("F2", CI));
            }

        }
    }
}
