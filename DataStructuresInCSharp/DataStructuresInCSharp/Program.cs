using DataStructuresInCSharp.Implementations._2_LinkedLists;
using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedListExample.RealWorldExample();

            LinkedList<string> test = new LinkedList<string>();
            LinkedListNode<string> node = test.First;

            Console.WriteLine(node);
            Console.ReadLine();

        }
    }
}
