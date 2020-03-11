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
                Console.WriteLine(simpleIntGeneric.Value);

                var simpleStringGeneric = new MySimpleGeneric<string>("Hello World!");
                Console.WriteLine(simpleStringGeneric.Value);
            }

            public static void SimpleCollectionGeneric()
            {
                Console.WriteLine("#######Simple Collection Generic Example#######");
                var fibonacci = new MySimpleCollectionGeneric<int>();
                fibonacci.Add(1).Add(2).Add(3).Add(5);

                foreach (var element in fibonacci.GetAll())
                {
                    Console.Write(element + " ");
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
                var phoneCountryPair = new MyMultipleGeneric<int, string>(380, "Ukraine");
                KeyValuePair<int, string> data = phoneCountryPair.GetPair();
                Console.WriteLine(string.Format("Key eqauls: {0}\nValue equals: {1}", 
                    data.Key, data.Value));
            }
        }
    }
}
