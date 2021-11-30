using System;
using Lecture04.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lecture04.Entities
{
    public class ProjectBankContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        //public DbSet<Character> Characters { get; set; }

        public ProjectBankContext(DbContextOptions<ProjectBankContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* modelBuilder
                .Entity<Student>()
                .Property(e => e.Gender)
                .HasConversion(new EnumToStringConverter<Gender>()); */
        }
    }
}
