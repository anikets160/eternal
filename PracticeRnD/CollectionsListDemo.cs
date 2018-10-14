using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeRnD
{
    public class CollectionsListDemo
    {

         public void ListDemo(string name1,string name2,string name3,string name4,string name5)
        {
            List<String> listOfNames = new List<string>();

            listOfNames.Add(name1);
            listOfNames.Add(name2);
            listOfNames.Add(name3);
            listOfNames.Add(name4);
            listOfNames.Add(name5);

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }



    }
}
