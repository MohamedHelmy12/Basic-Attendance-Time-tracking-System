﻿// <auto-generated />
using System;
using MVC_Attendance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Attendance.Migrations
{
    [DbContext(typeof(AttDbContext))]
<<<<<<<< HEAD:MVC_Attendance/Migrations/20240417124206_m1.Designer.cs
    [Migration("20240417124206_m1")]
    partial class m1
========
    [Migration("20240405022211_add-migration m5")]
    partial class addmigrationm5
>>>>>>>> master:MVC_Attendance/Migrations/20240405022211_add-migration m5.Designer.cs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_Attendance.Models.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<TimeOnly>("AttendanceTime")
                        .HasColumnType("time");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("LeavingTime")
                        .HasColumnType("time");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("UserId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("MVC_Attendance.Models.ITIProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ITIPrograms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Professional Training Program"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Intensive Training Program"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Summer Training Program"
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Intake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProgramId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Intakes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "44",
                            ProgramId = 1
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.IntakesTracks", b =>
                {
                    b.Property<int>("IntakeId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IntakeId", "TrackId");

                    b.HasIndex("TrackId");

                    b.ToTable("IntakesTracks");

                    b.HasData(
                        new
                        {
                            IntakeId = 1,
                            TrackId = 1,
                            Status = "Active"
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Permission", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "date");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<TimeOnly>("StartDate")
                        .HasColumnType("time");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(2024, 4, 20),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(2024, 4, 21),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateOnly(2024, 4, 22),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateOnly(2024, 4, 23),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateOnly(2024, 4, 24),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateOnly(2024, 4, 25),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateOnly(2024, 4, 27),
                            StartDate = new TimeOnly(9, 0, 0),
                            TrackId = 1
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.StdIntakeTrack", b =>
                {
                    b.Property<int>("IntakeId")
                        .HasColumnType("int");

                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("IntakeId", "TrackId", "StudentId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TrackId");

                    b.ToTable("StdIntakeTrack");

                    b.HasData(
                        new
                        {
                            IntakeId = 1,
                            TrackId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            IntakeId = 1,
                            TrackId = 1,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Supervise", b =>
                {
                    b.Property<int>("TrackId")
                        .HasColumnType("int");

                    b.Property<int>("IntakeId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("TrackId", "IntakeId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("IntakeId");

                    b.ToTable("Supervises");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            IntakeId = 1,
                            InstructorId = 4
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Professional Web Development and BI"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Open Source"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Artificial Intelegence"
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Admin@admin.com",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "Admin@123",
                            Phone = "01111111111",
                            role = 3
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Employee", b =>
                {
                    b.HasBaseType("MVC_Attendance.Models.User");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Email = "Mahmoud@gmail.com",
                            FirstName = "Mahmoud",
                            LastName = "Mahmoud",
                            Password = "Mahmoud@123",
                            Phone = "01111111111",
                            role = 2,
                            EmployeeType = 0,
                            HireDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Salary = 10000.0
                        },
                        new
                        {
                            Id = 7,
                            Email = "Ashraf@gmail.com",
                            FirstName = "Ashraf",
                            LastName = "Ashraf2",
                            Password = "admin@123",
                            Phone = "01111111111",
                            role = 2,
                            EmployeeType = 1,
                            HireDate = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Salary = 10000.0
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Instructor", b =>
                {
                    b.HasBaseType("MVC_Attendance.Models.User");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Email = "Nadya@gmail.com",
                            FirstName = "Nadya",
                            LastName = "Saleh",
                            Password = "Nadya@123",
                            Phone = "01111111111",
                            role = 1
                        },
                        new
                        {
                            Id = 5,
                            Email = "Ayman@gmail.com",
                            FirstName = "Ayman",
                            LastName = "Lotfy",
                            Password = "Ayman@123",
                            Phone = "01111111111",
                            role = 1
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Student", b =>
                {
                    b.HasBaseType("MVC_Attendance.Models.User");

                    b.Property<double>("AbsenceDegree")
                        .HasColumnType("float");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GraduationYear")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfAbsences")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Address = "Kafr El Shi5, Egypt",
                            Email = "Ali@gmail.com",
                            FirstName = "Ali",
                            LastName = "Ali2",
                            Password = "Ali@123",
                            Phone = "01111111111",
                            role = 0,
                            AbsenceDegree = 0.0,
                            Faculty = "Engineering",
                            GraduationYear = 2023,
                            NumberOfAbsences = 0,
                            Specialization = "Computer Science",
                            UniversityID = "Kafr El Shi5"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Tanta, Egypt",
                            Email = "Ahmed@gmail.com",
                            FirstName = "Ahmed",
                            LastName = "Ahmed2",
                            Password = "Ahmed@123",
                            Phone = "01111111111",
                            role = 0,
                            AbsenceDegree = 0.0,
                            Faculty = "Engineering",
                            GraduationYear = 2023,
                            NumberOfAbsences = 0,
                            Specialization = "Mechancial Engineering",
                            UniversityID = "Tanta"
                        });
                });

            modelBuilder.Entity("MVC_Attendance.Models.Attendance", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Schedule", "Schedule")
                        .WithMany("Attendances")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.User", "User")
                        .WithMany("Attendances")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Intake", b =>
                {
                    b.HasOne("MVC_Attendance.Models.ITIProgram", "Program")
                        .WithMany("Intakes")
                        .HasForeignKey("ProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Program");
                });

            modelBuilder.Entity("MVC_Attendance.Models.IntakesTracks", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Intake", "Intake")
                        .WithMany()
                        .HasForeignKey("IntakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Intake");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Permission", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Student", "Student")
                        .WithMany("Permissions")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Schedule", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MVC_Attendance.Models.StdIntakeTrack", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Intake", "Intake")
                        .WithMany()
                        .HasForeignKey("IntakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Intake");

                    b.Navigation("Student");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Supervise", b =>
                {
                    b.HasOne("MVC_Attendance.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.Intake", "Intake")
                        .WithMany()
                        .HasForeignKey("IntakeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_Attendance.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Intake");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Employee", b =>
                {
                    b.HasOne("MVC_Attendance.Models.User", null)
                        .WithOne()
                        .HasForeignKey("MVC_Attendance.Models.Employee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Attendance.Models.Instructor", b =>
                {
                    b.HasOne("MVC_Attendance.Models.User", null)
                        .WithOne()
                        .HasForeignKey("MVC_Attendance.Models.Instructor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Attendance.Models.Student", b =>
                {
                    b.HasOne("MVC_Attendance.Models.User", null)
                        .WithOne()
                        .HasForeignKey("MVC_Attendance.Models.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_Attendance.Models.ITIProgram", b =>
                {
                    b.Navigation("Intakes");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Schedule", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("MVC_Attendance.Models.User", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("MVC_Attendance.Models.Student", b =>
                {
                    b.Navigation("Permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
