using SantaNaughtyNiceData.Models;

namespace SantaNaughtyNiceData
{
    public class StartingData
    {
        public static List<Children> GetChildren()
        {
            List<Children> children = new List<Children>();
            Children child = new Children()
            {

                FirstName = "Tom",
                LastName = "Smith",
                House_Number = 32,
                StreetName = "Main Street",
                CityName = "Dallas",
                PostalCode = "12345",
                CountryName = "USA",
                Yearly_ANNS = 15,
                Historical_ANNS = 25,
                ChildHistory = new List<ChildsHistory>()
            };
            children.Add(child);
            child = new Children()
            {

                FirstName = "Sarah",
                LastName = "Jones",
                House_Number = 15,
                StreetName = "Second Street",
                CityName = "Plano",
                PostalCode = "54321",
                CountryName = "USA",
                Yearly_ANNS = -15,
                Historical_ANNS = 10,
                ChildHistory = new List<ChildsHistory>()

            };
            children.Add(child);
            child = new Children()
            {

                FirstName = "Robert",
                LastName = "Jamerson",
                House_Number = 84,
                StreetName = "Maple Street",
                CityName = "Atlanta",
                PostalCode = "34215",
                CountryName = "USA",
                Yearly_ANNS = 500,
                Historical_ANNS = -45,
                ChildHistory = new List<ChildsHistory>()
            };
            children.Add(child);
            return children;
        }
        public static List<Activities> GetActivities()
        {
            List<Activities> activities = new List<Activities>();
            Activities activity = new Activities()
            {

                Description = "Clean Room",
                Value = 5
            };
            activities.Add(activity);
            activity = new Activities()
            {

                Description = "Cry in public",
                Value = -20
            };
            activities.Add(activity);
            activity = new Activities()
            {

                Description = "Cook Dinner",
                Value = 10
            };
            activities.Add(activity);
            activity = new Activities()
            {

                Description = "Genocide",
                Value = -500
            };
            activities.Add(activity);
            return activities;
        }
        public static List<ChildsHistory> GetChildHistory()
        {
            List<ChildsHistory> childHistories = new List<ChildsHistory>();
            ChildsHistory childHistory = new ChildsHistory()
            {

                ChildID = 1,
                ActivityID = 1,
                DeltaANNS = 5,
            };
            childHistories.Add(childHistory);
            childHistory = new ChildsHistory()
            {

                ChildID = 1,
                ActivityID = 3,
                DeltaANNS = 10,
            };
            childHistory = new ChildsHistory()
            {

                ChildID = 2,
                ActivityID = 4,
                DeltaANNS = -500,
            };
            childHistories.Add(childHistory);
            return childHistories;
        }
    }
}
