using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            System.Collections.SortedList sortedList = new System.Collections.SortedList();
            System.Collections.Hashtable hashtable = new System.Collections.Hashtable();
            System.Collections.Stack stack = new System.Collections.Stack();
            System.Collections.Queue queue = new System.Collections.Queue();

            #region [Non-Generic Collections]

            Console.WriteLine("Non-Generic Colletions::");

            #region ArrayList

            // Array List
            arrayList.Add(1);
            arrayList.Add("Aniket");
            arrayList.Add(10.33);
            arrayList.Add(true);
            arrayList.Add('A');

            Console.WriteLine("******=>ArrayList");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            #endregion

            #region SortedList

            sortedList.Add(1, "Aniket");
            sortedList.Add(7, "Pallavi");
            sortedList.Add(5, 10.33);
            sortedList.Add(2, true);
            sortedList.Add(9, 'S');
            Console.WriteLine("******=>Sorted List");
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

            Console.WriteLine("******=>Hashtable");

            //Console.WriteLine(hashtable.Keys);

            foreach (object item in hashtable.Keys)
            {
                Console.WriteLine(hashtable[item]);
            }

            //for (int i = 0; i < hashtable.Count; i++)
            //{
            //    Console.WriteLine(hashtable[2]);
            //}

            Console.WriteLine();
            #endregion

            #region Stack
            stack.Push(1);
            stack.Push("Aniket");
            stack.Push(3.12);
            stack.Push('C');
            stack.Push(true);
            Console.WriteLine("******=>Stack");
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());

            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region Queue

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("******=>Queue");
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Count);


            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            #endregion

            #endregion
            
            #region [Generic Colletions]

            Console.WriteLine();
            Console.WriteLine("Generic Colletions::");
            Console.WriteLine();

            System.Collections.Generic.List<int> list = new List<int>();
            System.Collections.Generic.SortedList<double, string> sortedListGenric = new SortedList<double, string>();
            System.Collections.Generic.HashSet<double> hashSet = new HashSet<double>();
            System.Collections.Generic.SortedSet<string> sortedSet = new SortedSet<string>();
            System.Collections.Generic.Dictionary<int, string> dictionary = new Dictionary<int, string>();
            System.Collections.Generic.SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            System.Collections.Generic.Stack<int> stackGenric = new Stack<int>();
            System.Collections.Generic.Queue<bool> queueGeneric = new Queue<bool>();

            #region List

            Console.WriteLine("******=>List");

            list.Add(10);
            list.Add(9);
            list.Add(12);
            list.Add(13);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region SortedList

            Console.WriteLine("******=>Sorted List");
            sortedListGenric.Add(16, "Aniket");
            sortedListGenric.Add(9, "Pallavi");
            sortedListGenric.Add(5, "Shubham");
            sortedListGenric.Add(8, "Nakul");

            foreach (var item in sortedListGenric)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            #endregion

            #region HashSet

            Console.WriteLine("******=>HashSet");
            hashSet.Add(11.11);
            hashSet.Add(44.22);
            hashSet.Add(33.33);

            for (int i = 0; i < hashSet.Count; i++)
            {
                Console.WriteLine(hashSet.ElementAt(i));
            }

            Console.WriteLine();

            #endregion

            #region SortedSet

            Console.WriteLine("******=>SortedSet");

            sortedSet.Add("Brad");
            sortedSet.Add("Pallavi");
            sortedSet.Add("Aniket");
            
            for (int i = 0; i < sortedSet.Count; i++)
            {
                Console.WriteLine(sortedSet.ElementAt(i));
            }

            Console.WriteLine();

            #endregion


            #endregion

            Console.ReadKey();
        }
    }
}
