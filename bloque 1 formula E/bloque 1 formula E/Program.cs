﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_1_formula_E
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, y, f;

            Console.Write("INGRESE EL VALOR DE A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE D: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE F: ");
            f = int.Parse(Console.ReadLine());

            y = (d * ((3 * c) + Math.E)) - (((f - (2 * a)) / (b + 6)) / (7 * (Math.Pow(((4 * d) - a), 2))));

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
