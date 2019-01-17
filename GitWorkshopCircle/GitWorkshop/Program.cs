using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = 0;
           Console.WriteLine("Please enter the radius: ");
           radius =  float.Parse(Console.ReadLine());

            var circle = new Circle(radius);
            Console.WriteLine("The Area of a Circle with radius {0} is {1}",radius,circle.Area);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
