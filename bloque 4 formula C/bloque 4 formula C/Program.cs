using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_4_formula_C
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

            y = (3 * c * a - Math.Pow(b, 2)) * (9 / (5 - 4 * Math.Pow(c, 2)) + d);

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
