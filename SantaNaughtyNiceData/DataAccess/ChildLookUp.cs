using SantaNaughtyNiceData.Models;

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
