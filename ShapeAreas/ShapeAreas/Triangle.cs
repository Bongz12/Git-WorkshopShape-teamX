using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    class Triangle
    {
        public static void calculate()
        {
            Console.WriteLine("Enter Height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Base");
            int bse = Convert.ToInt32(Console.ReadLine());
            double ans = 0.5 * bse * height;
            Console.WriteLine(ans);

        }
    }
}
