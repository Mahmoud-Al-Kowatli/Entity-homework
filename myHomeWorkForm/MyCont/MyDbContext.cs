using Microsoft.EntityFrameworkCore;
using myhomework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using myHomeWorkForm.Mod;

namespace myHomeWorkForm.MyCont
{
    public class MyDbContext : DbContext
    {

        public virtual DbSet<Department> departments1 { get; set; }
        public virtual DbSet<Subject> subjects1 { get; set; }
        public virtual DbSet<Exam> exams1 { get; set; }
        public virtual DbSet<StudentsMark> studentmarks1 { get; set; }
        public virtual DbSet<SubjectLecture> subjectLectures1 { get; set; }

        //public MyDbContext() : base("name=MyDbContext")
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DOI5329;Initial Catalog=homeworkDB;Integrated Security=True; TrustServerCertificate=True ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().HasMany(x => x.Exams)
            //    .WithMany(y => y.Students).UsingEntity(j => j.ToTable("studentmarks1"));

            //modelBuilder.Entity<Exam>() .HasMany(x =>x.Students )
            //   .WithMany(y => y.Exams).UsingEntity(j => j.ToTable("StudentsMark"));

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> students1 { get; set; }

    }
}
