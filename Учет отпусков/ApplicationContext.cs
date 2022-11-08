using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Учет_отпусков.Models;

namespace Учет_отпусков
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; } = null!;
        public DbSet<VacationSet>  VacationSets{ get; set; } = null!;

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=VacatonBase.db");
        }
    }
}
