using System;

namespace DIExample
{
    public class ConsoleWriter : IConsoleWriter
    {
        private ISingletonDemo singletonDemo;
        public ConsoleWriter(ISingletonDemo singletonDemo)
        {
            this.singletonDemo = singletonDemo;
        }
        public void LogMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("From ConsoleWriter: " + singletonDemo.ObjectId);
        }
    }
}
