using System;
using System.Globalization;

namespace vet10_aprovados {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N;

            Console.Write("Quantos alunos serao digitados? ");
            N = int.Parse(Console.ReadLine());

            string[] nomes = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for (int i = 0; i < N; i++) {
                Console.WriteLine("Digite o nome, primera e segunda nota do " + (i+1) + "o aluno:");
                nomes[i] = Console.ReadLine();
                nota1[i] = double.Parse(Console.ReadLine(), CI);
                nota2[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++) {
                if ((nota1[i] + nota2[i]) / 2 >= 6.0) {
                    Console.WriteLine(nomes[i]);
                } 
            }

        }
    }
}
