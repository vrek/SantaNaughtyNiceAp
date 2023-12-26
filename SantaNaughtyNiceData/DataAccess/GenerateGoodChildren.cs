using CsvHelper;
using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData.DataAccess
{
    public class GenerateGoodChildren
    {
        public static List<Children> GenerateGoodChildrenList (ChildrenDBContext db) 
        {
            List<Children> goodchildren = new List<Children>();
            foreach(var child in db.children)
            {
                if(child.Yearly_ANNS >= 0 && child.Historical_ANNS >=0)
                {
                    goodchildren.Add(child);
                }
            }
            return goodchildren;
        }
        public static void OutputChildren(List<Children>GoodChildren, ChildrenDBContext db)
        {
            string outputFile = Path.Combine(Path.GetTempPath(), "GoodChildren.csv");
            using var writer = new StreamWriter(outputFile);
            using CsvWriter csvOut = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvOut.WriteRecords(GoodChildren);
        }
    }
}
