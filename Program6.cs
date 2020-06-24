using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Shape
    {
        public const double pI = 3.14;
        public void calculateArea(float x)
        {
            Console.WriteLine("Area of the square: " + x * x + " sq units");
        }
        public void calculateArea(float x, float y)
        {
            Console.WriteLine("Area of the rectangle: " + x * y + " sq units");
        }
        public void calculateArea(double r)
        {
            double area = pI * r * r;
            Console.WriteLine("Area of the circle: " + area + " sq units");
        }
    }
    public class Shape_Test
    {
        static void Main()
        {
            Shape shape = new Shape();
            shape.calculateArea(5.1f);
            shape.calculateArea(10, 32);
            shape.calculateArea(7.1);
            Console.ReadKey();
        }
    }
}