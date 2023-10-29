
// Write a program in C# to find the magnitude of a number.

using System;

namespace c
{
    class pro
    {
        public static void Main(string[] args)
        {
            int n, i = 0;
            Console.WriteLine("Enter a Value: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                i++;
                n = n / 10;
            }
            Console.WriteLine("Number of digits: " + i);
        }
    }
}