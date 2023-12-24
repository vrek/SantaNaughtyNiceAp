using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData.DataAccess
{
    public class ChildLookUp
    {
        public ChildrenDBContext childrenDBContext = new();
        public string _firstName = null;
        public string _lastName = null;

        ChildLookUp(string firstName, string lastName) {
            this._firstName = firstName;
            this._lastName = lastName;
        }
        //public int getYearlyANNS(string firstName, string lastName)
        //{
        //    IQueryable children = childrenDBContext.children.AsQueryable();
        //    foreach (var child in children)
        //    {
        //        //if child.firstName.Text =
        //    }
        //    return 0;
        //}
    }
}
