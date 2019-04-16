using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IntroductionToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome: Please enter your first name:  ");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Welcome: Please enter your last name:  ");
            //string lastName = Console.ReadLine();

            //Console.WriteLine("Hello {0}, {1}", firstName,lastName);            

            //Console.WriteLine("##############");

            
            //Integer Array
            //int[] array = new int[2];
            //array[0] = 1;
            //array[1] = "Aniket";

            //Object Array
            object[] array = new object[3];
            array[0] = 1;
            array[1] = "Aniket";

            Customer customer = new Customer();

            customer.Id = 106;
            customer.Name = "Aniket";

            array[2] = customer;

            foreach(object obj in array)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("##############");
            Console.ReadKey();

            Console.WriteLine("##############");

            // ArrayList
            ArrayList arrayList = new ArrayList();
            arrayList.Add(2);
            arrayList.Add("Palle");
            arrayList.Add(customer);

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("##############");
            Console.ReadKey();
        }

        class Customer
        {

            public int Id { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return this.Name;
            }

            //public int Int()
            //{
            //    return this.Id;
            //}


            //public new string ToString()
            //{
            //    return this.Name;
            //}
        }

    }
}
