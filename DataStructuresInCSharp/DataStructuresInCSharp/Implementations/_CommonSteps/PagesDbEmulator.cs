using System.Collections.Generic;

namespace DataStructuresInCSharp.Implementations._CommonSteps
{
    public class PagesDbEmulator
    {
        private static Dictionary<string, int> ScorePerPage = new Dictionary<string, int>();
       
        public static Dictionary<string, int> GetScorePerPage()
        {
            ScorePerPage.Add("https://football.ua/", 30);
            ScorePerPage.Add("https://football.ua/newsarc/", 10);

            return ScorePerPage;
        }
    }
}
