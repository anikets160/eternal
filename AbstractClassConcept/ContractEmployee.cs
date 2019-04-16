using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConcept
{
    public class ContractEmployee:BaseEmployee
    {
        //public int ID { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }

        //public string GetFullName()
        //{
        //    return this.FirstName + " " + LastName;
        //}

        //public override int GetMonthlySalary()
        //{
        //    return this.TotalHours * this.HourlyPay;
        //}

        public override int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }

    }
}
