using AdapterExample.Contracts;
using System;

namespace AdapterExample.Models
{
    public class Employee : IEmployee
    {
        private string name;

        public Employee(string name)
        {
            this.name = name;
        }

        public void ShowHappiness()
        {
            Console.WriteLine("Employee " + this.name + " showed happiness");
        }
    }
}
