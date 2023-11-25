using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Context
{
    internal class UniContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=SchoolDb;Trusted_Connection=true;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entites.Course>().Property(x => x.Id).UseIdentityColumn(1, 1);
            modelBuilder.Entity<Entites.Course>().Property(x => x.Name).HasMaxLength(40).HasColumnType("varchar");
            modelBuilder.Entity<Entites.Course>().Property(x => x.InstructorName).HasMaxLength(40).HasColumnType("varchar");

        }
        public DbSet<Entites.Student> Students { get; set; }
        public DbSet<Entites.Instructor> Instructors{ get; set; }
        public DbSet<Entites.Course> Courses { get; set; }
    }
}
