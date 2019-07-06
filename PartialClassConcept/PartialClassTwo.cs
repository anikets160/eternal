using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassConcept
{
    public partial class Employee
    {
        private int _salary;

        public void PrintDetails()
        {
            Console.WriteLine(_id + " " + _name);
        }

        public void PrintSalary()
        {
            Console.WriteLine(_salary);
        }
    }
}
