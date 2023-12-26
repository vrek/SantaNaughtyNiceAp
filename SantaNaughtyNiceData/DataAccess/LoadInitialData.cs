using SantaNaughtyNiceData.Models;


namespace SantaNaughtyNiceData.DataAccess
{
    public class LoadInitialData
    {
        public static int LoadInitialChildren()
        {
            using (var db = new ChildrenDBContext())
            {
                db.ChangeTracker.Clear();
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
                int value_changes = -1;
                try
                {
                    value_changes = db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new Exception();
                }
                return value_changes;
            }
        }
    }
}
