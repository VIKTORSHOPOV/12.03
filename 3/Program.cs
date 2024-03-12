using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[2];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                students[i].Input();
            }
            Console.WriteLine("Search for student with fac number: ");
            int search = int.Parse(Console.ReadLine());
            Student.SearchByFacultyNumber(students, search);
        }
    }
}
