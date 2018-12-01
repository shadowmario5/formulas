using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_1_formula_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x, y;

            Console.Write("INGRESE EL VALOR DE X: ");
            x = int.Parse(Console.ReadLine());

            y = (Math.Pow((-5 * x), 3)) + (2 * x) - 9;

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
