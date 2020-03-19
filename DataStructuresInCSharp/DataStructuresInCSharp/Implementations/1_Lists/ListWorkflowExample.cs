using System;
using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._1_Lists
{
    public class ListWorkflowExample
    {
        public static void BaseActions()
        {
            //List initialization
            var footballTeams = new List<string>();

            //List filling
            footballTeams.Add("Manchester United");
            footballTeams.AddRange(new string[] { "FC Dnipro", "Dynamo Kyiv" });

            //List initialization and filling
            var exFootballTeams = new List<string> { "FC Metalist Kharkiv" };

            //Get Count
            int teamsCount = footballTeams.Count;
            Console.WriteLine("Teams count = " + teamsCount);

            //Find and get element
            int index = footballTeams.BinarySearch("FC Dnipro");
            Console.WriteLine("FC Dnipro index is " + index);
            string team = footballTeams[index];
            Console.WriteLine($"Team found by index {index} is {team}", index, team);

            //Check if list contains some element
            bool isContains = footballTeams.Contains("Dynamo Kyiv");
            Console.WriteLine("Contains Dynamo Kyiv? " + isContains);

            //Remove element
            footballTeams.Remove("FC Dnipro");

            //Clear all list
            exFootballTeams.Clear();
        }

        public static void BaseExampleArray()
        {
            var footballTeams = new string [] { "Manchester United" };

            var footballTeams2 = new string[2] { "FC Dnipro", "Dynamo Kyiv" };
        }

       
    }
}
