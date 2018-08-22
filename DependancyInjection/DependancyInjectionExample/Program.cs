using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace DependancyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            // Register 
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>().LifestyleTransient());

            // Resolve (ask the container for an instance)
            var root = container.Resolve<ICompositionRoot>();
            root.LogMessage("Hello from my very first resolved class!");


            // Wait for user input so they can check the program's output.
            Console.ReadLine();
        }
    }
}
