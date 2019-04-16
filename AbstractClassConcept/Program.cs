using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConcept
{

    // Abstract Classes
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Aniket",
                LastName = "Shrikondawar",      
                AnnualSalary = 1200000
                
            };

            Console.WriteLine(fullTimeEmployee.GetFullName());
            Console.WriteLine(fullTimeEmployee.GetMonthlySalary());

            Console.WriteLine("- - - - - - - - - - ");

            ContractEmployee contractEmployee = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Pallavi",
                LastName = "Shrikondawar",
                HourlyPay = 700,
                TotalHours = 40

            };

            Console.WriteLine(contractEmployee.GetFullName());
            Console.WriteLine(contractEmployee.GetMonthlySalary());
            Console.ReadKey();
        }
    }
}
