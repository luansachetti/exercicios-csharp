using System;
using System.Globalization;

namespace rep_while03_senha_fixa {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int senha, x;

            senha = 2002;

            Console.Write("Digite a senha: ");
            x = int.Parse(Console.ReadLine());

            while (x != senha) {
                Console.Write("Senha Invalida! Tente novamente: ");
                x = int.Parse(Console.ReadLine());
            }

            if (x == senha) {
                Console.WriteLine("Acesso Permitido!");
            }

        }
    }
}
