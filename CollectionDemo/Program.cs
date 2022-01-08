using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictinaryDemo();
        }

       
        private static void doListDemo()
        {
            Console.WriteLine("\n In doListDemo()");
            List<string> list = new List<string>();

            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        private static void doStackDemo()
        {
            Console.WriteLine("\n In doStackDemo()");

            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Popped element : " + pop);
        }

        private static void doQueueDemo()
        {
            Console.WriteLine("\n In doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("\nIterating the queue elements");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }

            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue element: " + dequeue);

            Console.WriteLine("\n Iterating the queue elements after dequeue one element");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }

        private static void doSetDemo()
        {
            Console.WriteLine("\n In doSetDemo");

            var set = new HashSet<string>();

            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        private static void doDictinaryDemo()
        {
            Console.WriteLine("\n In doDictinaryDemo");
            Dictionary<int, string> dictory = new Dictionary<int, string>();
            dictory.Add(100, "Amit");
            dictory.Add(150, "Rahul");
            dictory.Add(180, "Vijay");

            Console.WriteLine("Access value using Key(key=100): " + dictory[100]);

            Console.WriteLine("\n Iterating Dictionary:");
            foreach (var element in dictory)
            {
                Console.WriteLine("key = " + element.Key + "& value = " + element.Value);
            }
        }
    
    }
}
