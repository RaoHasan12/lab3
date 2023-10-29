
// Write a C# programs to demonstrate the concepts of multilevel Inheritance

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication8
{
    class a
    {
        public void display()
        {
            Console.WriteLine("MY");
        }
    }
    class b : a //b is child of a
    {
        public void display1()
        {
            Console.WriteLine("NAME");
        }
    }
    class d : b //d is child of b
    {
        public void display2()
        {
            Console.WriteLine("IS RHT");
        }
    }
    class c
    {
        public static void Main()
        {
            d x = new d();//Normally object of child
            x.display();
            x.display1();
            x.display2();
        }
    }
}