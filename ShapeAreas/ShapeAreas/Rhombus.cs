using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    class Rhombus
    {
        private void calculate()
        {
            Console.WriteLine("Enter 1st diag");
            double diag1 = Console.Read();

            Console.WriteLine("Enter 2nd diag");
            double diag2 = Console.Read();

            double area = (diag1 * diag2) / 2;
            Console.WriteLine("Your Area = " + area);
        }
    }
}
