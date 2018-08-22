namespace DIExample
{
    public class CompositionRoot : ICompositionRoot
    {
        private readonly IConsoleWriter consoleWriter;
        private readonly ISingletonDemo singletonDemo;

        public CompositionRoot(IConsoleWriter consoleWriter, ISingletonDemo singletonDemo)
        {
            this.consoleWriter = consoleWriter;
            this.singletonDemo = singletonDemo;
        }

        public void LogMessage(string message)
        {
            var msg = "Singleton object id:" + singletonDemo.ObjectId;
            consoleWriter.LogMessage(msg);
            consoleWriter.LogMessage(message);
        }
    }
}
