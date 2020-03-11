using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructuresInCSharp.Implementations._3_HashTable
{
    public class DictionaryExample
    {
        public static void BaseExamples() 
        {
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("QA", "Quality Assurance Engineer");
            dictionary.Add("DEV", "Software developer");
            dictionary.Add("PjM", "Project Manager");
            dictionary.Add("PO", "Product Owner");
            //dictionary.Add("QA", "Tester");

            string fullDesciption = dictionary["QA"];
            Console.WriteLine(fullDesciption);

            bool hasKey = dictionary.ContainsKey("DEV");
            bool hasValue = dictionary.ContainsValue("Tester");

            List<string> allKeys = dictionary.Keys.ToList();
            List<string> allValues = dictionary.Values.ToList();
        }

        public static void RealExample()
        {
            RestartWindowsService(GetServiceName("timeBroker"));
        }

        private static string GetServiceName(string key)
        {
            var windowsServices = new Dictionary<string, string>
            {
                { "timeBroker", "TimeBrokerSvc" },
                { "remoteDesktop", "TermService" },
                { "spotVerifier", "svsvc" }
            };

            return windowsServices[key];
        }


        private static void RestartWindowsService(string realServiceName)
        {
            Console.WriteLine($"Restarting service {realServiceName}");
        }
    }
}
