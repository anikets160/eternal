using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    abstract class A
    {
        public int a;
        public void Add()
        {
            Console.WriteLine("Abstract Method Add");
        }

        public abstract void Sum();
    }
    
    interface I1
    {
        
        void M1();
    }

    class Program : A,I1
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Sum();
            p.M1();

            A a = new Program();
            a.Add();
            a.Sum();
            

            I1 a1 = new Program();
            a1.M1();

            Console.ReadKey();
        }

        public void M1()
        {
            Console.WriteLine("Interface method M1 Implementation");
        }

        public override void Sum()
        {
            Console.WriteLine("Abstract Class Method Sum Implementation");
        }
    }
}
