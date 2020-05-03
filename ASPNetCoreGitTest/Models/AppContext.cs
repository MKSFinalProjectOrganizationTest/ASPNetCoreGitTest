using ASPNetCoreGitTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreGitTest
{
    public class AppContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "data source=.\\SQLEXPRESS; initial catalog=TestDB; integrated security=SSPI";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
