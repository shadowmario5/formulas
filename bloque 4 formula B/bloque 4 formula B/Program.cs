using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_4_formula_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, y;

            Console.Write("INGRESE EL VALOR DE A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE D: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE E: ");
            e = int.Parse(Console.ReadLine());

            y = ((c - 7 * a) / b) / Math.Pow(e, 5) + (3 / 2) * ((5 * c - 8) / (9 - Math.Pow(a, 2)));

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
