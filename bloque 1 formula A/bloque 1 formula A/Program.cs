using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bloque_1_formula_A
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

            y = (((a * c) - 5) / (7 * b)) - (9 * a);

            Console.Write("EL VALOR DE Y ES " + y + "\n");

            Console.ReadKey();
        }
    }
}
