using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            System.Collections.SortedList sortedList = new System.Collections.SortedList();
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            System.Collections.Stack stack = new System.Collections.Stack();
            System.Collections.Queue queue = new System.Collections.Queue();

            #region ArrayList

            // Array List
            arrayList.Add(1);
            arrayList.Add("Aniket");
            arrayList.Add(10.33);
            arrayList.Add(true);
            arrayList.Add('A');

            foreach (var item in arrayList)
            {
                Console.WriteLine("ArrayList {0}", item);
            }

            Console.WriteLine();
            #endregion

            #region SortedList

            sortedList.Add(1, "Aniket");
            sortedList.Add(7, "Pallavi");
            sortedList.Add(5, 10.33);
            sortedList.Add(2, true);
            sortedList.Add(9, 'S');

            for (int i = 0; i < sortedList.Count; i++)
            {
                Console.WriteLine(sortedList.GetByIndex(i));
            }

            Console.WriteLine();
            #endregion

            #region HashTable

            hashtable.Add(2, "Aniket");
            hashtable.Add(true, "Pallavi");
            hashtable.Add(1, 12.44);
            hashtable.Add(20, 'Z');
            hashtable.Add(false, 2);

            Console.WriteLine(hashtable[1]);

            //foreach (object item in hashtable)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //for (int i = 0; i < hashtable.Count; i++)
            //{
            //    Console.WriteLine(hashtable[2]);
            //}

            Console.WriteLine();
            #endregion

            Console.ReadKey();


            System.Collections.Generic.List<int> list = new List<int>();
            System.Collections.Generic.SortedList<double, string> sortedListGenric = new SortedList<double, string>();
            System.Collections.Generic.HashSet<double> hashSet = new HashSet<double>();
            System.Collections.Generic.SortedSet<string> sortedSet = new SortedSet<string>();
            System.Collections.Generic.Dictionary<int, string> dictionary = new Dictionary<int, string>();
            System.Collections.Generic.SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            System.Collections.Generic.Stack<int> stackGenric = new Stack<int>();
            System.Collections.Generic.Queue<bool> queueGeneric = new Queue<bool>();



        }
    }
}
