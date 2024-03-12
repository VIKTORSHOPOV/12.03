using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        

        public void Display()
        {
            Console.WriteLine($"Point coordinates: {X} {Y}");
        }

        public int[] Translation(int vx, int vy)
        {
            return new int[] { X + vx, Y + vy };
        }

        public double[] Rotation(int radians)
        {
            return new double[] { X * Math.Cos(radians) - Y * Math.Sin(radians), X * Math.Cos(radians) + Y * Math.Cos(radians) };
        }

        public int[] Scale(int sx, int sy)
        {
            return new int[] { X * sx, Y * sy };
        }
    }
}
