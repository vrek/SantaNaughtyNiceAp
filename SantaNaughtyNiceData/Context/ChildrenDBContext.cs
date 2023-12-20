using Microsoft.EntityFrameworkCore;
using SantaNaughtyNiceData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaNaughtyNiceData
{
    public class ChildrenDBContext : DbContext
    {
        public ChildrenDBContext(DbContextOptions options ) : base(options){ }
        public DbSet<Children> children {  get; set; }
        public DbSet<ChildsHistory> childsHistory { get; set; }
        public DbSet<Activities> activities { get; set; }

    }
}
