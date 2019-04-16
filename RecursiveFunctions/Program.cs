using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunctions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial {0}",Program.Factorial(5));
            Console.WriteLine("Factorial {0}", Program.WithRecursionFactorial(5));
            Console.ReadKey();
        }

        // Without recursive function
        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;

            for (int i =number; i>=1;i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        // With recursive function
        public static double WithRecursionFactorial(int number)
        {
            if (number == 0)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
