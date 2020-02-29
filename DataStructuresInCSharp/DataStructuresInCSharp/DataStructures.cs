using DataStructuresInCSharp.Implementations._0_Generics;
using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp
{
    public class DataStructures
    {
        public static class Generics
        {
            public static void SimpleGeneric()
            {
                Console.WriteLine("#######Simple Generic Example#######");
                var simpleIntGeneric = new MySimpleGeneric<int>(20);
                Console.WriteLine(simpleIntGeneric.GetGeneric());

                var simpleStringGeneric = new MySimpleGeneric<string>("Hello World!");
                Console.WriteLine(simpleStringGeneric.GetGeneric());
            }

            public static void SimpleCollectionGeneric()
            {
                Console.WriteLine("#######Simple Collection Generic Example#######");
                var fibonacci = new MySimpleCollectionGeneric<int>();
                fibonacci.AddNew(1).AddNew(2).AddNew(3).AddNew(5);

                foreach (var element in fibonacci.GetAll())
                {
                    Console.WriteLine(element);
                }
            }

            public static void SimpleGenericWithConstrains()
            {
                Console.WriteLine("#######Simple Generic Constrains Example#######");
                //Correct datatype
                var stringTemplate = new SimpleGenericOnlyReference<string>("TestData");
                Console.WriteLine(stringTemplate.isEqual("TestData"));

                //Incorrect datatype
                //var intTemplate = new SimpleGenericOnlyReference<int>(20);
            }

            public static void MultipleValuesGeneric()
            {
                Console.WriteLine("#######Multiple Value Generic Example#######");
                var keyCityPair = new MyMultipleGeneric<int, string>(1, "Kyiv");
                KeyValuePair<int, string> data = keyCityPair.GetPair();
                Console.WriteLine(string.Format("Key eqauls: {0}\nValue equals: {1}", data.Key, data.Value));
            }
        }
    }
}
