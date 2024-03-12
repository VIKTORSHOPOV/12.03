using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter width of rectangle:");
            Width = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of rectangle:");
            Height = double.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}");
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}
