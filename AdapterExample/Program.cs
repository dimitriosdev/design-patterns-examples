using AdapterExample.Contracts;
using AdapterExample.Models;
using System;
using System.Collections.Generic;

namespace AdapterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEmployee> list = new List<IEmployee>();
            list.Add(new Employee("Tom"));
            list.Add(new Employee("Jerry"));
            list.Add(new EmployeeAdapter("Bruno"));  //consultant from existing class
            ShowHappiness(list);
            Console.ReadKey();
        }

        static void ShowHappiness(List<IEmployee> list)
        {
            foreach (IEmployee i in list)
                i.ShowHappiness();
        }
    }
}
