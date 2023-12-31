using Microsoft.EntityFrameworkCore;
using SantaNaughtyNiceData.Models;

namespace SantaNaughtyNiceData
{
    public class ChildrenDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LG72A81;" +
                "Initial Catalog=Santa;" +
                "Integrated Security=True;" +
                "Connect Timeout=30;" +
                "Encrypt=False;" +
                "Trust Server Certificate=False;" +
                "Application Intent=ReadWrite;" +
                "Multi Subnet Failover=False");
        }
        public DbSet<Children> children { get; set; }
        public DbSet<ChildsHistory> childsHistory { get; set; }
        public DbSet<Activities> activities { get; set; }

    }
}
