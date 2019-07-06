using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter target number: ");
            //int target = int.Parse(Console.ReadLine());

            //int start = 0;

            //while (start <= target)
            //{
            //    Console.WriteLine(start);

            //    start = start + 2;
            //}

            //Console.ReadKey();

            ////

            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Please enter target number: ");

                int target = int.Parse(Console.ReadLine());

                int start = 0;
                while (start <= target)
                {
                    Console.WriteLine(start);

                    start = start + 2;
                }            
                        
            do
            {
                Console.WriteLine("Do you want to continue? Yes or No");
                userChoice = Console.ReadLine().ToLower();
                if (userChoice!="yes" && userChoice!="no")
                {
                    Console.WriteLine("Invalid Choice");
                }
            } while (userChoice != "yes" && userChoice != "no");
            } while (userChoice == "yes");
        }
    }
}
