using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._1_Lists
{
    public class ListWorflowExample
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

            //Find and get element
            int index = footballTeams.BinarySearch("FC Dnipro");
            string team = footballTeams[index];

            //Check if list contains some element
            bool isContains = footballTeams.Contains("Dynamo Kyiv");

            //Remove element
            footballTeams.Remove("FC Dnipro");

            //Clear all list
            exFootballTeams.Clear();
        }

       
    }
}
