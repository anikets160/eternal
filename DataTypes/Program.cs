using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 11;


            //ternery operator
            bool IsNumber10 = (number == 10) ? true : false;

            //if (number==10)
            //{
            //    IsNumber10 = true;
            //}
            //else
            //{
            //    IsNumber10 = false;
            //}



            Console.WriteLine("Number == 10 is {0}", IsNumber10);
            //Console.ReadKey();
            // nullable data type
            int? i = null;
            i = 10;
            bool? AreYouMajor = null;
            Console.WriteLine(i);
            Console.ReadKey();

        }
    }
}
