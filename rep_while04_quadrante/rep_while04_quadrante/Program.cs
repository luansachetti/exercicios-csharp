﻿using System;
using System.Globalization;

namespace rep_while04_quadrante {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, y;

            Console.WriteLine("Digite os valores das coordenadas X e Y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("QUADRANTE Q1");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("QUANDRANTE Q2");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("QUADRANTE Q3");
                }
                else if (x > 0 && y < 0) {
                    Console.WriteLine("QUADRANTE Q4");
                }
                Console.WriteLine("Digite os valores das coordenadas X e Y:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
