using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game
{
    class Stats
    {

        public string Name { get; set; }
        public int Flag { get; set;}
        public string Stamp { get; set; }

        public Stats(string Line)
        {
            Flag = 0;
            var splt = Line.Split(',');
            Name = splt[0];
            if(splt[1]!="0")
            {
                Flag = 1;
            }
            Stamp = splt[2];            

        }
    }
    class Helper
    {

        public List<string> ReadFromCSV()
        {
            string filePath = @"..\..\Files/stats.csv";
            var listOfObjects = File.ReadLines(filePath).Select(line => new Stats(line)).ToList();

            ////gROUP bY nAME
            //var groupedList = listOfObjects
            //        .GroupBy(u => u.Name)
            //        .Select(grp => grp.ToList())
            //        .ToList();
            var groupSum = listOfObjects
                    .GroupBy(u => u.Name)
                    .Select(t => new
                    {
                        Name=t.Key,
                        Score=t.Sum(ta=>ta.Flag)
                    }
                    ).ToList() ;

            var orderedList = groupSum.OrderByDescending(g => g.Score).Take(3).Select(s => s.Name);

            return orderedList.ToList();

            
        }

        public List<string> GetScoreList(string crntName)
        {
            List<string> lstReturn = new List<string>();
            int tmpVal = 0;
            string filePath = @"..\..\Files/stats.csv";
            var listOfObjects = File.ReadLines(filePath).Select(line => new Stats(line)).ToList();

            var lstScore = listOfObjects.Where(e => e.Name == crntName) .ToList().Select(s=>s.Flag) ;
            
            foreach(int x in lstScore)
            {
                tmpVal = 10 * x;
                lstReturn.Add(tmpVal.ToString());

            }

            return lstReturn.ToList();


        }


        public void AddtoCSV(string name,bool FlagSuccess )
        {
            string filePath = @"..\..\Files/stats.csv";
            StringBuilder linetxt = new StringBuilder();
            linetxt.Append(name + ",");
            
            if (FlagSuccess)
            {
                linetxt.Append("1,");
            }
            else
            {
                linetxt.Append("0,");
            }
            linetxt.Append(DateTime.Now.ToString() + Environment.NewLine);

            File.AppendAllText(filePath, linetxt.ToString());

            //using (CsvFileWriter writer = new CsvFileWriter(@"..\..\Files/stats.csv"))
            //{
            //    CsvRow row = new CsvRow();
            //    row.Add(name);
            //    if (FlagSuccess)
            //    {
            //        row.Add("1");
            //    }
            //    else
            //    {
            //        row.Add("0");
            //    }
            //    row.Add(DateTime.Now.ToString());
            //    writer.WriteRow(row);
            //}

        }
    }

    public class CsvRow : List<string>
    {
        public string LineText { get; set; }
    }

    public class CsvFileWriter : StreamWriter
    {
        public CsvFileWriter(Stream stream)
            : base(stream)
        {
        }

        public CsvFileWriter(string filename)
            : base(filename)
        {
        }

        /// <summary>
        /// Writes a single row to a CSV file.
        /// </summary>
        /// <param name="row">The row to be written</param>
        public void WriteRow(CsvRow row)
        {
            StringBuilder builder = new StringBuilder();
            bool firstColumn = true;
            foreach (string value in row)
            {
                // Add separator if this isn't the first value
                if (!firstColumn)
                    builder.Append(',');
                // Implement special handling for values that contain comma or quote
                // Enclose in quotes and double up any double quotes
                if (value.IndexOfAny(new char[] { '"', ',' }) != -1)
                    builder.AppendFormat("\"{0}\"", value.Replace("\"", "\"\""));
                else
                    builder.Append(value);
                firstColumn = false;
            }

            row.LineText = builder.ToString();
            

        }
    }




}
