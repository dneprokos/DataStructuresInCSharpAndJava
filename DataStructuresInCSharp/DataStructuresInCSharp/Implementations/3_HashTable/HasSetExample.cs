using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._3_HashTable
{
    public class HasSetExample
    {
        public static void BaseExamples()
        {
            //Add 
            var set = new HashSet<int>();
            set.Add(1);
            set.Add(1);
            set.Add(2);
            set.Add(3);

            set.ToList().ForEach(el => Console.WriteLine(el));

            //Is Contain
            bool isContain = set.Contains(2);
            Console.WriteLine("Is 2 present in a set: " + isContain);

            //Set size
            int setCount = set.Count;
            Console.WriteLine("Set elements count: " + setCount);

            //Remove
            set.Remove(2);

            //You can also use sorted set
            var sortedSet = new SortedSet<int>(new int [] { 3, 0, 2, 1 });
            sortedSet.ToList().ForEach(el => Console.WriteLine(el));
        }
        
        public static void RealExample()
        {
            var mergedSource = new HashSet<int>();
            var dataSource1 = new int[] { 1, 2, 5, 7, 8, 10 };
            var dataSource2 = new int[] { 1, 3, 4, 7, 8, 9, 10 };

            dataSource1.ToList().ForEach(v => mergedSource.Add(v));
            dataSource2.ToList().ForEach(v => mergedSource.Add(v));

            mergedSource.ToList().ForEach(h => Console.WriteLine(h));
        }    
    }
}
