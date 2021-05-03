using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            listDemo();
            stackDemo();
            queueDemo();
            setDemo();
            dictionaryDemo();
            Console.ReadKey();
        }

        private static void dictionaryDemo()
        {
            Console.WriteLine("\nIn Dictionary Demo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Vijay");
            dictionary.Add(102, "Rahul");

            Console.WriteLine("Access Value Using Key(102)= "+ dictionary[102]);

            Console.WriteLine("\nIterating Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key=" + element.Key," & Value=" + element.Value);
            }

        }
        private static void queueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            queue.Enqueue("Head:" + queue.Peek());
            Console.WriteLine("\nIterating the queue elements:");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element:" + dequeue);
            Console.WriteLine("\nIterating the queue elements after dequeue one element:");
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
           
        }
        private static void listDemo()
        {
            Console.WriteLine("\n In Do List Demo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ajay");
            list.Add("Prit");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void stackDemo()
        {
            Console.WriteLine("\n In stackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Aarushi");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            //Iterating stack elements
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped element: " + pop);
                
        }  
        private static void setDemo()
        {
            Console.WriteLine("\nIn setDemo");
            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Rahul");
            set.Add("Prit"); ;

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

        }
    }
}
