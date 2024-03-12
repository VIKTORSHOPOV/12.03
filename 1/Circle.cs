using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Circle
    {
        public double Radius { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter radius of circle:");
            Radius = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Circle - Radius: {Radius}");
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
