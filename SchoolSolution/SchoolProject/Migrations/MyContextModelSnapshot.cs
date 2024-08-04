﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolProject.Context;

namespace SchoolProject.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolProject.Models.Course", b =>
                {
                    b.Property<int>("course_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("course_Capicity")
                        .HasColumnType("int");

                    b.Property<string>("course_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("teacher_Id")
                        .HasColumnType("int");

                    b.Property<int?>("teacher_Id1")
                        .HasColumnType("int");

                    b.HasKey("course_Id");

                    b.HasIndex("teacher_Id1");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolProject.Models.Room", b =>
                {
                    b.Property<int>("room_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("room_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("room_Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("SchoolProject.Models.Student", b =>
                {
                    b.Property<int>("student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Photo_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("student_Age")
                        .HasColumnType("int");

                    b.Property<string>("student_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("student_Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolProject.Models.StudentCourse", b =>
                {
                    b.Property<int>("studentCourse_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("course_Id")
                        .HasColumnType("int");

                    b.Property<int?>("course_Id1")
                        .HasColumnType("int");

                    b.Property<int>("student_Id")
                        .HasColumnType("int");

                    b.Property<int?>("student_Id1")
                        .HasColumnType("int");

                    b.HasKey("studentCourse_Id");

                    b.HasIndex("course_Id1");

                    b.HasIndex("student_Id1");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("SchoolProject.Models.Teacher", b =>
                {
                    b.Property<int>("teacher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("teacher_Age")
                        .HasColumnType("int");

                    b.Property<string>("teacher_Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("teacher_Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("SchoolProject.Models.Course", b =>
                {
                    b.HasOne("SchoolProject.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("teacher_Id1");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SchoolProject.Models.StudentCourse", b =>
                {
                    b.HasOne("SchoolProject.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("course_Id1");

                    b.HasOne("SchoolProject.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("student_Id1");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
