using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game
{
   
    public static class Global
    {
        public static string gamername = "";
        public static int attempts = 0;
        public static string previoustxt = "";
        public static bool gamestarted = false;
        public static int wordmatchcounter = 0;
        public static int maxAttempts = 2;
        public static string name = "";
    }

    public class Words
    {
        private string filePath = @"..\..\Files/WordsList.csv";
        public List<string> lstwords;

        public Words()
        {
            var tmplstwords = File.ReadLines(filePath);
            string tmpwords = tmplstwords.First();
            lstwords = tmpwords.Split(',').ToList();
        }

        public List<string> ListWords
        {
            get { return lstwords; }
        }



    }




}
