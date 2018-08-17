using System;

namespace FacadeExample
{
    /// <summary>
    /// The façade design pattern allows you to provide a simplified interface from multiple class libraries. 
    /// It provides a simple interface that hides the complexity of the class libraries being used. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Facade();
            f.DoSomething();
            Console.ReadKey();
        }
    }
}
