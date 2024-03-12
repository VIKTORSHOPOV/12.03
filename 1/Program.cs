using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("Choose a shape to calculate area:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Rectangle rectangle = new Rectangle();
                    rectangle.Input();
                    Console.WriteLine("\nDetails and area of rectangle:");
                    rectangle.Display();
                    Console.WriteLine($"Area: {rectangle.Area():F2}");
                    break;

                case 2:
                    Triangle triangle = new Triangle();
                    triangle.Input();
                    Console.WriteLine("\nDetails and area of triangle:");
                    triangle.Display();
                    Console.WriteLine($"Area: {triangle.Area():F2}");
                    break;

                case 3:
                    Circle circle = new Circle();
                    circle.Input();
                    Console.WriteLine("\nDetails and area of circle:");
                    circle.Display();
                    Console.WriteLine($"Area: {circle.Area():F2}");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}

