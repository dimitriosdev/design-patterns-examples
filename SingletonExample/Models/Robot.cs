using System;

namespace SingletonExample.Models
{
    /// <summary>
    /// The code implicitly uses LazyThreadSafetyMode.ExecutionAndPublication as the thread safety mode for the Lazy<Robot>. 
    /// </summary>
    public sealed class Robot
    {
        private static readonly Lazy<Robot> lazy = new Lazy<Robot>(() => new Robot());
        private string name;
        
        public static Robot Instance { get { return lazy.Value; } }

        private Robot() { }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
