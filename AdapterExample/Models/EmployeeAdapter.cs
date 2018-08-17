using AdapterExample.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterExample.Models
{
    public class EmployeeAdapter : Consultant, IEmployee
    {
        public EmployeeAdapter(string name) : base(name)
        {
        }
        void IEmployee.ShowHappiness()
        {
            base.ShowSmile();
        }
    }
}
