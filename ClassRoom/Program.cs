using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom programming = new ClassRoom() { ClassName = "3Q Beginning of the semester", SemesterStart = new DateTime(2020, 8, 24), 
                ClassList = new List<Student>() { new Student("Justin", 12, 31), new Student("Andreas", 2, 7), new Student("Dominik", 11, 9) } };

            Console.WriteLine(programming.ClassName);
            Console.WriteLine(programming.SemesterStart);
            foreach (Student student in programming.ClassList)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
