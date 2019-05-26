using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesConcept
{
    public delegate void NameDelegate(string Name);
    public delegate void SalaryDelegate(int Salary);

    class Program
    {
        public static void PrintName(string Name)
        {
            Console.WriteLine(Name);
        }

        public static void PrintSalary(int Salary)
        {
            Console.WriteLine(Salary);
        }

        
        static void Main(string[] args)
        {
            NameDelegate nameDelegate = new NameDelegate(PrintName);
            nameDelegate("Aniket");
            nameDelegate("Pallavi");
            nameDelegate("Sheela");
            nameDelegate("Ashok");
            nameDelegate("Shubham");

            SalaryDelegate salaryDelegate = new SalaryDelegate(PrintSalary);
            salaryDelegate(1200000);
            Console.ReadKey();
        }
    }
}
