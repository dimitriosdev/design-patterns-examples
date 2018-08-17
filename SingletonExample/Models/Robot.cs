namespace SingletonExample.Models
{
    public class Robot
    {
        private static Robot self;
        private string name;
        private Robot() {}

        public static Robot Instance()
        {
            if (self == null)
                self = new Robot();
            return self;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
