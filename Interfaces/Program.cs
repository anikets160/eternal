using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IA
    {
        void M1();
    }

    interface IB : IA
    {
        void M2();
    }

    interface IC : IB
    {
        void M3();
    }

    interface ID
    {
        void M4();
    }

    class D : Program,IC,ID
    {
        public void M1()
        {
            Console.WriteLine("Interface IA method");
        }

        public void M2()
        {
            Console.WriteLine("Interface IB method");
        }

        public void M3()
        {
            Console.WriteLine("Interface IC method");
        }

        public void M4()
        {
            Console.WriteLine("Interface ID method");
        }
    }

    class A
    {

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            IC c = new D();
            c.M1();
            c.M2();
            c.M3();

            D d = new D();
            d.M4();

            Console.ReadKey();
        }
    }
}
