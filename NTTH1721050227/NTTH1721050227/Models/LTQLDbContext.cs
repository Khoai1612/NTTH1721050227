using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTTH1721050227.Models
{
    public partial class LTQLDbContext : DbContext
    {
        public LTQLDbContext()
            : base("name=LTQLDbContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
             .Property(e => e.PersonID)
             .IsUnicode(true);
            modelBuilder.Entity<Person>()
            .Property(e => e.PersonName)
            .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
               .Property(e => e.Faculty)
               .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Department)
                .IsUnicode(true);
        }
    }
}
