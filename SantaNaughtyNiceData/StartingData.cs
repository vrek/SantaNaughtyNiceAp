using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData
{
    public class StartingData
    {
        public static List<Children> GetChildren()
        {
            List<Children> children = new List<Children>();
            Children child = new Children()
            {
                Id = 1,
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
                Id = 2,
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
                Id = 3,
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
                Id = 1,
                Description = "Clean Room",
                Value = 5
            };
            activities.Add(activity);
            activity = new Activities()
            {
                Id = 2,
                Description = "Cry in public",
                Value = -20
            };
            activities.Add(activity);
            activity = new Activities()
            {
                Id = 3,
                Description = "Cook Dinner",
                Value = 10
            };
            activities.Add(activity);
            activity = new Activities()
            {
                Id = 4,
                Description = "Genocide",
                Value = -500
            };
            activities.Add(activity);
            return activities;
        }
    }
}
