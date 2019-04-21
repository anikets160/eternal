using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "Aniket", 1600000);

            //employee.PrintDetails();

            employee.PrintDetails();

            employee.PrintSalary();
            Console.ReadKey();
        }
    }
}
