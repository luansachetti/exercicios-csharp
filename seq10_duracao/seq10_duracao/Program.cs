﻿using System;
using System.Globalization;

namespace seq10_duracao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int horas, minutos, segundos, duracao, resto;

            Console.Write("Digite a duracao em segundos: ");
            duracao = int.Parse(Console.ReadLine());

            horas = duracao / 3600;
            resto = duracao % 3600;

            minutos = resto / 60;

            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }
    }
}
