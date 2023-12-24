using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData.DataAccess
{
    public static class ChildLookUp
    {
        
        public static int getYearlyANNS(string firstName, string lastName)
        {
            using (var db = new ChildrenDBContext())
            {
                
                foreach (Children child in db.children)
                {
                    if (child.FirstName == firstName && child.LastName == lastName)
                    {
                        return child.Yearly_ANNS;

                    }
                }                
            }
            return 0;
        }
        public static int getHistoricalANNS(string firstName, string lastName)
        {
            using (var db = new ChildrenDBContext())
            {

                foreach (Children child in db.children)
                {
                    if (child.FirstName == firstName && child.LastName == lastName)
                    {
                        return child.Historical_ANNS;

                    }
                }
            }
            return 0;
        }
    }
}
