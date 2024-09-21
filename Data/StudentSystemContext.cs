using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data
{
    internal class StudentSystemContext:DbContext
    { 
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Integrated Security=True;Initial Catalog = StudentSystem ;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .Property(e => e.Name)
                 .HasMaxLength(100)
                 .IsUnicode(true);

            modelBuilder.Entity<Student>()
                .Property(e => e.PhoneNumber)
                 .HasMaxLength(10)
                 .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Name)
                 .HasMaxLength(80)
                 .IsUnicode(true);

            modelBuilder.Entity<Course>()
               .Property(e => e.Description)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
               .Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            modelBuilder.Entity<Resource>()
              .Property(e => e.Url)
              .IsUnicode(false);

            modelBuilder.Entity<StudentCourse>()
            .HasKey(e => new { e.StudentId, e.CourseId });





        }
    }
}
