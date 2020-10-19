using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApi13Oct2020.Controllers
{
    public class CFLDBContext : DbContext
    {
        public CFLDBContext(DbContextOptions<CFLDBContext> options)
       : base(options)
        { }

        public CFLDBContext()
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UVR8UE5;Database=CFLDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .ToTable("Team");
        }
          public DbSet<Team> Teams { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}
