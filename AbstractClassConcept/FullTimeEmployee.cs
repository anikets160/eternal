using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConcept
{
    public class FullTimeEmployee:BaseEmployee
    {
        //public int ID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int AnnualSalary { get; set; }

        //public string GetFullName()
        //{
        //    return this.FirstName + " " + LastName;
        //}

        //public override int GetMonthlySalary()
        //{
        //    return this.AnnualSalary / 12;
        //}

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}
