using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter base of triangle:");
            Base = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of triangle:");
            Height = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Triangle - Base: {Base}, Height: {Height}");
        }

        public double Area()
        {
            return 0.5 * Base * Height;
        }
    }
}
