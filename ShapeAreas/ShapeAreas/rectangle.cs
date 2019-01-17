using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    class rectangle
    {

        

        public static void calculateRectangleArea()
        {
            Console.WriteLine("Please enter the length of the rectangle");
            double length= Console.Read();
            Console.WriteLine("Please enter the Width of the rectangle");
            double width=Console.Read();
            
            

            double val = length * width;
            Console.WriteLine(val);


        }
    }
}
