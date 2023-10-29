
// Write a C# programs to demonstrate the concepts of Default Constructors

using System;
namespace ConsoleApplication3
{
    class Sample
    {
        public string param1, param2;
        public Sample() // Default Constructor
        {
            param1 = "Welcome";
            param2 = "VISUAL STUDIO RHT";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Console.WriteLine(obj.param1);
            Console.WriteLine(obj.param2);
            Console.ReadLine();
        }
    }
}