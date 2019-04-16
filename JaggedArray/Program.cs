using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    // Jagged array is an array of array
    class Program
    {
        static void Main(string[] args)
        {

            string[] employeeNames = new string[3];
            employeeNames[0] = "Mark";
            employeeNames[1] = "Matt";
            employeeNames[2] = "John";


            //array of string arrays - jagged array
            string[][] jaggedArray = new string[3][];

            //set the size of 3 string arrays in jagged array
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            //First string array
            jaggedArray[0][0] = "Bachelors";
            jaggedArray[0][1] = "Masters";
            jaggedArray[0][2] = "Doctorate";

            //Second string array
            jaggedArray[1][0] = "bachelors";

            //Third string array
            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";

            for(int i=0;i < jaggedArray.Length;i++)
            {
                string[] innerArray = jaggedArray[i];
                Console.WriteLine(employeeNames[i]);
                Console.WriteLine("________");
                for(int j = 0;j <innerArray.Length;j++)
                {
                    Console.WriteLine(innerArray[j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
