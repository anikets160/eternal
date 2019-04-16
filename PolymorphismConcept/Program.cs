using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConcept
{

    public class Base
    {
        // Method Hiding
        public void Add()
        {
            Console.WriteLine("Base Class Add Method");
        }
    }

    public class Child : Base
    {
        // Method Hiding
        public new void Add()
        {
            Console.WriteLine("Child Class Add Method");
        }
    }

    //public class Base
    //{
    //    Method Overriding
    //    public virtual void Add()
    //    {
    //        Console.WriteLine("Base Class Add Method");
    //    }
    //}

    //public class Child : Base
    //{
    //    Method Overriding
    //    public override void Add()
    //    {
    //        Console.WriteLine("Child Class Add Method");
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Method Hiding
            Base b = new Child();
            b.Add();
            Child c = new Child();
            c.Add();
            Console.ReadKey();

            //// Method Overriding
            //Base b = new Child();
            //b.Add();            
            //Console.ReadKey();

        }
    }
}
