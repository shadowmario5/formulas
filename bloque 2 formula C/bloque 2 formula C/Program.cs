using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_2_formula_C
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

            y = (d + (5 * a)) * ((d + ((3 / 4) * (a + (7 * b)))) / ((-3 * c) + d) / (Math.Pow(b, 2)));

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
