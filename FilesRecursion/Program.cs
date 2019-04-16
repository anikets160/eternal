using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Path");
            string path = Console.ReadLine();
            FindFiles(path);
            Console.ReadLine();
        }

        private static void FindFiles(string path)
        {
            foreach(string fileName in Directory.GetFiles(path))
            {
                Console.WriteLine(fileName);
            }

            foreach (string directory in Directory.GetDirectories(path))
            {
                FindFiles(directory);
            }

        }
    }
}
