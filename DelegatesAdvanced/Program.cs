using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAdvanced
{

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Employee> empList = new List<Employee>();
    //        empList.Add(new Employee() { ID = 1, Name = "Aniket1", Salary = 100001, Experience = 6 });
    //        empList.Add(new Employee() { ID = 2, Name = "Aniket2", Salary = 100002, Experience = 7 });
    //        empList.Add(new Employee() { ID = 3, Name = "Aniket3", Salary = 100003, Experience = 4 });
    //        empList.Add(new Employee() { ID = 4, Name = "Aniket4", Salary = 100004, Experience = 3 });

    //        Employee.PromoteEmployee(empList);
    //        Console.ReadKey();
    //    }
    //}

    //class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //    public int Experience { get; set; }

    //    public static void PromoteEmployee(List<Employee> EmployeeList)
    //    {
    //        foreach (var employee in EmployeeList)
    //        {
    //            if (employee.Experience>5)
    //            {
    //                Console.WriteLine("Employee Promoted {0}", employee.Name);
    //            }
    //        }
    //    }

    //}

    /// <summary>
    /// ///////////////////////////////////////
    /// </summary>

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Employee> empList = new List<Employee>();
    //        empList.Add(new Employee() { ID = 1, Name = "Aniket1", Salary = 100001, Experience = 6 });
    //        empList.Add(new Employee() { ID = 2, Name = "Aniket2", Salary = 100002, Experience = 7 });
    //        empList.Add(new Employee() { ID = 3, Name = "Aniket3", Salary = 100003, Experience = 7 });
    //        empList.Add(new Employee() { ID = 4, Name = "Aniket4", Salary = 100004, Experience = 3 });

    //        IsPromotable isPromotable = new IsPromotable(Promote);

    //        Employee.PromoteEmployee(empList,isPromotable);
    //        Console.ReadKey();
    //    }

    //    public static bool Promote(Employee Employee)
    //    {
    //        if (Employee.Experience>5)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}

    //delegate bool IsPromotable(Employee employee);

    //class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //    public int Experience { get; set; }

    //    public static void PromoteEmployee(List<Employee> EmployeeList,IsPromotable IsEligibleToPromote)
    //    {
    //        foreach (var employee in EmployeeList)
    //        {
    //            if (IsEligibleToPromote(employee))
    //            {
    //                Console.WriteLine("Employee Promoted {0}", employee.Name);
    //            }
    //        }
    //    }

    //}

   //////////////////////////

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 1, Name = "Aniket1", Salary = 100001, Experience = 6 });
            empList.Add(new Employee() { ID = 2, Name = "Aniket2", Salary = 100002, Experience = 7 });
            empList.Add(new Employee() { ID = 3, Name = "Aniket3", Salary = 100003, Experience = 7 });
            empList.Add(new Employee() { ID = 4, Name = "Aniket4", Salary = 100004, Experience = 3 });

            Employee.PromoteEmployee(empList, emp => emp.Experience>5);
            Console.ReadKey();
        }

    }

    delegate bool IsPromotable(Employee employee);

    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employee> EmployeeList, IsPromotable IsEligibleToPromote)
        {
            foreach (var employee in EmployeeList)
            {
                if (IsEligibleToPromote(employee))
                {
                    Console.WriteLine("Employee Promoted {0}", employee.Name);
                }
            }
        }

    }
}
