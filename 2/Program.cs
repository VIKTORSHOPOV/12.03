using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            point1.X = input[0]; point1.Y = input[1];
            Point point2 = new Point();
            input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            //point2.X = input[0]; point2.Y = input[1];
            //Point point3 = new Point();
            //input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            //point3.X = input[0]; point3.Y = input[1];
            //Console.WriteLine($"{point1.Translation(2, 3)[0]} {point1.Translation(2, 3)[1]}");
            //Console.WriteLine($"{point2.Rotation(60)[0]:F2} {point2.Rotation(60)[1]:F2}");
            //Console.WriteLine($"{point3.Scale(2, 3)[0]} {point3.Scale(2, 3)[1]}");
            Rectangle rectangle = new Rectangle();
            rectangle.topLeft = point1; rectangle.width = 20; rectangle.height = 10;
            Console.WriteLine(rectangle.checkPoint(point2)); 

        }
    }
}
