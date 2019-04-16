using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcepts
{
    //public class Employee
    //{
    //    public string FirstName;
    //    public string LastName;
    //    public string Email;

    //    public void PrintFullName()
    //    {
    //        Console.WriteLine(FirstName + " " + LastName);
    //    }

    //}

    //public class FullTimeEmployee : Employee
    //{
    //    public float YearlySalary;
    //}

    //public class PartTimeEmployee : Employee
    //{
    //    public float HourlyRate;
    //}

    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Class Constructor");
        }

        public Parent(string Message)
        {
            Console.WriteLine(Message);
        }
    }


    public class Child : Parent
    {
        public Child() : base("Calling Parmeterized Constructor from Child")
        {
            Console.WriteLine("Child Class Constructor");
        }
    }
    
    

    class Program
    {
        static void Main(string[] args)
        {
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //fullTimeEmployee.FirstName = "Aniket";
            //fullTimeEmployee.LastName = "Shrikondawar";
            //fullTimeEmployee.YearlySalary = 100000;
            //fullTimeEmployee.PrintFullName();


            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.FirstName = "Pallavi";
            //partTimeEmployee.LastName = "Shrikondawar";
            //partTimeEmployee.HourlyRate = 200000;
            //partTimeEmployee.PrintFullName();

            Child c = new Child();

            Console.ReadKey();
        }
    }
}
