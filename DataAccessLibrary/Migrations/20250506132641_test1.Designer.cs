﻿// <auto-generated />
using System;
using DataAccessLibrary.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250506132641_test1")]
    partial class test1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLibrary.Models.Academic", b =>
                {
                    b.Property<int>("RankID")
                        .HasColumnType("int");

                    b.Property<string>("AcademicRank")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("RankID");

                    b.ToTable("Academic");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.AdminLogin", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginID"));

                    b.Property<string>("ActiveCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Control")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("Islogin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("LoginID");

                    b.HasIndex("RoleID");

                    b.ToTable("AdminLogin");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.College", b =>
                {
                    b.Property<int>("CollegeID")
                        .HasColumnType("int");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("CollegeID");

                    b.ToTable("College");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<bool>("Coursesituation")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Coursedate", b =>
                {
                    b.Property<int>("CourseNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseNumber"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CourseNumber");

                    b.HasIndex("CourseId");

                    b.ToTable("Coursedate");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Employ", b =>
                {
                    b.Property<int>("EmployID")
                        .HasColumnType("int");

                    b.Property<string>("EmployName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.HasKey("EmployID");

                    b.ToTable("Employ");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Ostad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CollegeID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployID")
                        .HasColumnType("int");

                    b.Property<string>("Father")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Kodmelli")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OstadFamily")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OstadId")
                        .HasColumnType("int");

                    b.Property<string>("OstadName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhonNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankID")
                        .HasColumnType("int");

                    b.Property<int>("academicRankID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CollegeID");

                    b.HasIndex("EmployID");

                    b.HasIndex("academicRankID");

                    b.ToTable("Ostad");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.OstadCourse", b =>
                {
                    b.Property<int>("OstadCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OstadCourseId"));

                    b.Property<int>("Course14CourseId")
                        .HasColumnType("int");

                    b.Property<int>("CourseNumber")
                        .HasColumnType("int");

                    b.Property<int>("Coursedate14CourseNumber")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Ostad14Id")
                        .HasColumnType("int");

                    b.Property<bool>("RegisterSituation")
                        .HasColumnType("bit");

                    b.HasKey("OstadCourseId");

                    b.HasIndex("Course14CourseId");

                    b.HasIndex("Coursedate14CourseNumber");

                    b.HasIndex("Ostad14Id");

                    b.ToTable("OstadCourse");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Roles", b =>
                {
                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.AdminLogin", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.Roles", "role")
                        .WithMany("adminlogin")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Coursedate", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.Course", "course")
                        .WithMany("coursedate")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Ostad", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.College", "college")
                        .WithMany("ostads5")
                        .HasForeignKey("CollegeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLibrary.Models.Employ", "employ")
                        .WithMany("ostads6")
                        .HasForeignKey("EmployID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLibrary.Models.Academic", "academic")
                        .WithMany("ostads4")
                        .HasForeignKey("academicRankID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("academic");

                    b.Navigation("college");

                    b.Navigation("employ");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.OstadCourse", b =>
                {
                    b.HasOne("DataAccessLibrary.Models.Course", "Course14")
                        .WithMany("ostadcourse1")
                        .HasForeignKey("Course14CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLibrary.Models.Coursedate", "Coursedate14")
                        .WithMany("ostadcourse2")
                        .HasForeignKey("Coursedate14CourseNumber")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataAccessLibrary.Models.Ostad", "Ostad14")
                        .WithMany("OstadCourses2")
                        .HasForeignKey("Ostad14Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course14");

                    b.Navigation("Coursedate14");

                    b.Navigation("Ostad14");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Academic", b =>
                {
                    b.Navigation("ostads4");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.College", b =>
                {
                    b.Navigation("ostads5");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Course", b =>
                {
                    b.Navigation("coursedate");

                    b.Navigation("ostadcourse1");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Coursedate", b =>
                {
                    b.Navigation("ostadcourse2");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Employ", b =>
                {
                    b.Navigation("ostads6");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Ostad", b =>
                {
                    b.Navigation("OstadCourses2");
                });

            modelBuilder.Entity("DataAccessLibrary.Models.Roles", b =>
                {
                    b.Navigation("adminlogin");
                });
#pragma warning restore 612, 618
        }
    }
}
