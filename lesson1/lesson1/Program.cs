using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Today {DateTime.Now}");
        }
    }
}
