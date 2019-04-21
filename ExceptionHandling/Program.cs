using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"D:\Sample\SampleText.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                Console.ReadKey();
            }
            catch(FileNotFoundException fileNotFoundException)
            {
                Console.WriteLine(fileNotFoundException.Message,"Please enter valid file path");
                Console.ReadKey();
            }
        }
    }
}
