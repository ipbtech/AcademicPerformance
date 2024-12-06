﻿using AcademicPerformance.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcademicPerformance.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Score> Scores { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            if (!Database.CanConnect())
                throw new Exception("Couldn't connect to the database");

            var connStr = Database.GetConnectionString();
            if (connStr != "Filename=:memory:" && Database.GetPendingMigrations().Any())
                Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Subject>().Property(e => e.Name).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<Student>().Property(e => e.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Score>().Ignore(e => e.Name);

            modelBuilder.Entity<Score>().HasOne(score => score.Subject).WithMany(subject => subject.Scores)
                .HasForeignKey(score => score.SubjectId).HasPrincipalKey(subject => subject.Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Score>().HasOne(score => score.Student).WithMany(student => student.Scores)
                .HasForeignKey(score => score.StudentId).HasPrincipalKey(student => student.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}