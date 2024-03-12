using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Student
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public int number { get; set; }

        public string specialty { get; set; }

        public void Input()
        {
            Console.WriteLine("Enter first middle and last name:");
            string[] input = Console.ReadLine().Split(' ');
            firstName = input[0];
            middleName = input[1];
            lastName = input[2];
            Console.WriteLine("Enter number");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter specialty");
            specialty = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine($"{firstName} {middleName} {lastName}");
            Console.WriteLine(number);
            Console.WriteLine(specialty);
        }

        public static void SearchByFacultyNumber(Student[] students, int facultyNumber)
        {
            foreach (var student in students)
            {
                if (student.number == facultyNumber)
                {
                    Console.WriteLine($"{student.firstName} {student.middleName} {student.lastName}");
                    Console.WriteLine($"{student.specialty}");
                    return;
                }
            }
            Console.WriteLine("No student found.");

        }
    }
}

