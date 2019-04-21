using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassConcept
{
    public partial class Employee
    {
        private int _id;
        private string _name;

        public Employee(int Id,string Name,int Salary)
        {
            _id = Id;
            _name = Name;
            _salary = Salary;
        }
       

    }
}
