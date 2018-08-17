using SingletonExample.Models;
using System;

namespace SingletonExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot a = Robot.Instance;
            Robot b = Robot.Instance;
            a.Name = "Dimi";

            
            Console.WriteLine("Robot's a name is: " + a.Name);
            Console.WriteLine("Robot's b name is: " + b.Name);
            Console.WriteLine("Oups. It is the same robot.");
            Console.ReadKey();
        }
    }
}
