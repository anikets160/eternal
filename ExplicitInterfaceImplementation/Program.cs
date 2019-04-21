using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void M();
    }

    interface I2
    {
        void M();
    }
    
    class Program : I1,I2
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.M();

            ((I1)p).M();
            ((I2)p).M();

            Console.ReadKey();
        }

        public void M()
        {
            Console.WriteLine("M Method");
        }

        //void I1.M()
        //{
        //    Console.WriteLine("I1 M Method");
        //}

        void I2.M()
        {
            Console.WriteLine("I2 M Method");
        }
    }
}
