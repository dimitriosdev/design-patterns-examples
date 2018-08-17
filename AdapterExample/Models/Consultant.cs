using System;

namespace AdapterExample.Models
{
    public class Consultant
    {
        private string name;

        public Consultant(string name)
        {
            this.name = name;
        }

        protected void ShowSmile()
        {
            Console.WriteLine("Consultant " + this.name + " showed smile");
        }
    }
}
