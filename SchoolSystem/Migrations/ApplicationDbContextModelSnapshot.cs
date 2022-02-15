﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolSystem.Data;

#nullable disable

namespace SchoolSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolSystem.Models.Career", b =>
                {
                    b.Property<int>("CareerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareerId"), 1L, 1);

                    b.Property<string>("Career_Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Career_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareerId");

                    b.ToTable("Careers");
                });

            modelBuilder.Entity("SchoolSystem.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<int>("Course_Credits")
                        .HasColumnType("int");

                    b.Property<string>("Course_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Student_Courses");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.StudentTeacher", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Student_Teachers");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.TeacherCourse", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teacher_Courses");
                });

            modelBuilder.Entity("SchoolSystem.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"), 1L, 1);

                    b.Property<int>("CareerId")
                        .HasColumnType("int");

                    b.Property<int>("Student_Age")
                        .HasColumnType("int");

                    b.Property<int>("Student_Gender")
                        .HasColumnType("int");

                    b.Property<string>("Student_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Student_Semester")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("CareerId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolSystem.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"), 1L, 1);

                    b.Property<string>("Teacher_Direction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teacher_Horary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teacher_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teacher_Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.StudentCourse", b =>
                {
                    b.HasOne("SchoolSystem.Models.Course", "Course")
                        .WithMany("Student_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolSystem.Models.Student", "Student")
                        .WithMany("Student_Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.StudentTeacher", b =>
                {
                    b.HasOne("SchoolSystem.Models.Student", "Student")
                        .WithMany("Student_Teachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolSystem.Models.Teacher", "Teacher")
                        .WithMany("Student_Teachers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolSystem.Models.JoinTables.TeacherCourse", b =>
                {
                    b.HasOne("SchoolSystem.Models.Course", "Course")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolSystem.Models.Teacher", "Teacher")
                        .WithMany("Teacher_Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolSystem.Models.Student", b =>
                {
                    b.HasOne("SchoolSystem.Models.Career", "Career")
                        .WithMany("Students")
                        .HasForeignKey("CareerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");
                });

            modelBuilder.Entity("SchoolSystem.Models.Career", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("SchoolSystem.Models.Course", b =>
                {
                    b.Navigation("Student_Courses");

                    b.Navigation("Teacher_Courses");
                });

            modelBuilder.Entity("SchoolSystem.Models.Student", b =>
                {
                    b.Navigation("Student_Courses");

                    b.Navigation("Student_Teachers");
                });

            modelBuilder.Entity("SchoolSystem.Models.Teacher", b =>
                {
                    b.Navigation("Student_Teachers");

                    b.Navigation("Teacher_Courses");
                });
#pragma warning restore 612, 618
        }
    }
}