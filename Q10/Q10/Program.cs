
// Write a C# programs to demonstrate the concepts of Hierarchical Inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal g = new Principal();
            g.Monitor();
            Teacher d = new Teacher();
            d.Monitor();
            d.Teach();
            Student s = new Student();
            s.Monitor();
            s.Learn();
            Console.ReadKey();
        }
        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("HASAN");
            }
        }
        class Teacher : Principal
        {
            public void Teach()
            {
                Console.WriteLine("MYSELF");
            }
        }
        class Student : Principal
        {
            public void Learn()
            {
                Console.WriteLine("ENJOY");
            }
        }
    }
}