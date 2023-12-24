using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData.DataAccess
{
    public class LoadInitialData
    {
        //public ChildrenDBContext childrenDBContext = new();

        public static void LoadInitialChildren()
        {
            using (var db = new ChildrenDBContext())
            {
                if (!db.children.Any())
                {
                    List<Children> initialChildren = StartingData.GetChildren();
                    foreach (var child in initialChildren)
                    {
                        db.children.Add(child);
                    }
                }
                if (!db.activities.Any())
                {
                    List<Activities> initialActivities = StartingData.GetActivities();
                    foreach (var activity in initialActivities)
                    {
                        db.activities.Add(activity);
                    }
                }
                if (!db.childsHistory.Any())
                {
                    List<ChildsHistory> initialHistories = StartingData.GetChildHistory();
                    foreach (var childHistory in initialHistories)
                    {
                        db.childsHistory.Add(childHistory);
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
