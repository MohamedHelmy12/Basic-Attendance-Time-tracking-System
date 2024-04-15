﻿using Microsoft.EntityFrameworkCore;
using System.Drawing;

using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace MVC_Attendance.Models
{
    public class AttDbContext : DbContext
    {
		// System.ArgumentException: ''AddDbContext' was called with configuration, but the context type 'AttDbContext' only declares a parameterless constructor. This means that the configuration passed to 'AddDbContext' will never be used. If configuration is passed to 'AddDbContext', then 'AttDbContext' should declare a constructor that accepts a DbContextOptions<AttDbContext> and must pass it to the base constructor for DbContext.'
        public AttDbContext(DbContextOptions<AttDbContext> options) : base(options) { }
		//public AttDbContext(DbContextOptions<AttDbContext> options) : base(options) { }
		//public AttDbContext()
		//{ }




		public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ITIProgram> ITIPrograms { get; set; }
        public virtual DbSet<Intake> Intakes { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<IntakesTracks> IntakesTracks { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<StdIntakeTrack> StdIntakeTrack { get; set; }
        public virtual DbSet<Supervise> Supervises { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().UseTptMappingStrategy();

            modelBuilder.Entity<IntakesTracks>().HasKey(it => new { it.IntakeId, it.TrackId });

            modelBuilder.Entity<StdIntakeTrack>().HasKey(SIT => new { SIT.IntakeId, SIT.TrackId, SIT.StudentId });

            modelBuilder.Entity<Supervise>().HasKey(s => new { s.TrackId, s.IntakeId, s.InstructorId });

            modelBuilder.Entity<Permission>().HasKey(p => new { p.StudentId, p.date });

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.;Database=AttendSysMVC;integrated security = true; trust server certificate = true");

        //}
    }

}       
