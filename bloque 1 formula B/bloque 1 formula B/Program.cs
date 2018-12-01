using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_1_formula_B
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, f, y;

            Console.Write("INGRESE EL VALOR DE A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("INGRESE EL VALOR DE F: ");
            f = int.Parse(Console.ReadLine());

            y = b * (Math.Pow(((a + (7 * f)) / 5), 3)) + 4;

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
