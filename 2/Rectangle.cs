using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Rectangle
    {
        public Point topLeft { get; set; }
        public int width { get; set; }
        public int height { get; set; }

        public void Display()
        {
            Console.WriteLine($"{topLeft.X} {topLeft.Y}");
            Console.WriteLine(width);
            Console.WriteLine(height);
        }

        public bool checkPoint(Point point)
        {
            if (point.X >= topLeft.X && point.X <= topLeft.X + width
        && point.Y >= topLeft.Y && point.Y <= topLeft.Y + height)
                return true;
            else
                return false;
        }
    }
}
