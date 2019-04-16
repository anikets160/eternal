using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableDataTypesAndNullColaescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? TicketsOnSale = null;

            //int AvailableTickets;

            //if(TicketsOnSale ==null)
            //{
            //    AvailableTickets = 0;
            //}
            //else
            //{
            //    // AvailableTickets = TicketsOnSale.Value; 
            //    //OR
            //    AvailableTickets = (int)TicketsOnSale;
            //}

            //Console.WriteLine(AvailableTickets);
            //Console.ReadKey();

            // OR
            // Null Coalescing Operator

            int AvailableTickets = TicketsOnSale ?? 70;
            
            Console.WriteLine(AvailableTickets);
            Console.ReadKey();



        }
    }
}
