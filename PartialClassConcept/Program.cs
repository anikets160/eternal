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
<<<<<<< HEAD
            //employee.PrintSalary();
            //Console.ReadKey();
=======

            employee.PrintSalary();
            Console.ReadKey();
>>>>>>> 5333b36dea81f3126d1a4993fe27ca31c79cb3bc
        }
    }
}
