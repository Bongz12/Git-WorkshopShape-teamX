using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    class Square
    {
        public int side;

        void calc()
        {
            Console.WriteLine("Enter length of the square");
            side = Console.Read();

            int area = side * side;

            Console.WriteLine("Area = " + area);

        }

    }
}
