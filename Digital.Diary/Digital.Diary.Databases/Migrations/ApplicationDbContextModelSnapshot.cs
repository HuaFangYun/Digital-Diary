﻿// <auto-generated />
using System;
using Digital.Diary.Databases.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digital.Diary.Databases.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.CrTable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("CrTable", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Dean", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Dean", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Department", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Designation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DesignationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designation", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Faculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FacultyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculty", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DesignationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.ToTable("Staff", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DesignationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("FacultyId");

                    b.ToTable("Teacher", "Academic");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.TeacherFaculty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FacultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeachersFaculty");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.CrTable", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Department", "Department")
                        .WithMany("CrTables")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Dean", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Faculty", "Faculty")
                        .WithMany("Deans")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Department", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Faculty", "Faculty")
                        .WithMany("Departments")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Staff", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Department", "Department")
                        .WithMany("Staffs")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Designation");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Teacher", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Department", "Department")
                        .WithMany("Teachers")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Faculty", "Faculty")
                        .WithMany("Teachers")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Designation");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.TeacherFaculty", b =>
                {
                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Faculty", "Faculty")
                        .WithMany()
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digital.Diary.Models.EntityModels.Academic.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Department", b =>
                {
                    b.Navigation("CrTables");

                    b.Navigation("Staffs");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("Digital.Diary.Models.EntityModels.Academic.Faculty", b =>
                {
                    b.Navigation("Deans");

                    b.Navigation("Departments");

                    b.Navigation("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
