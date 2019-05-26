using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 2;

            Sum(i, j);

            int k = 10;
            int l = 20;

            Multiply(ref k, ref l);

            Console.WriteLine("{0}  {1}", k, l);

            int o;
            int p;

            AddSubtract(5, 4, out o, out p);
            Console.WriteLine(o);
            Console.WriteLine(p);

            int[] empployeeList = new int[5] {1,2,3,4,5 };

            EmployeeCount(empployeeList);

            Console.ReadKey();

        }

        public static void Sum(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Multiply(ref int a, ref int b)
        {
            a = 30;
            b = 40;
            Console.WriteLine(a*b);
        }

        public static void AddSubtract(int a,int b,out int Total,out int Decreament)
        {
            Total = a + b;
            Decreament = a - b;
        }

        public static void EmployeeCount(params int[] EmployeeList)
        {
            Console.WriteLine(EmployeeList.Length);
            foreach (var item in EmployeeList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
