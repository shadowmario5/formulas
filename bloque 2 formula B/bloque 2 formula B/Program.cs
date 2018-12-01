using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_2_formula_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, y;

            Console.Write("INGRESE EL VALOR DE A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE D: ");
            d = int.Parse(Console.ReadLine());

            y = ((Math.Pow(((4 * b) + (Math.Pow(a, 2))), 3)) / (c - (5 * b))) + (6 * a);

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
