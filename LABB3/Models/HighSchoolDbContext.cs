using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LABB3.Models
{
    public partial class HighSchoolDbContext : DbContext
    {
        public HighSchoolDbContext()
        {
        }

        public HighSchoolDbContext(DbContextOptions<HighSchoolDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<DepEmp> DepEmps { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<StudCourse> StudCourses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-7SVCCJN;Initial Catalog=BeverlyHillsEconomyAndScienceHighSchool;Integrated Security = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("classID");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(15)
                    .HasColumnName("className");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId)
                    .ValueGeneratedNever()
                    .HasColumnName("courseID");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(25)
                    .HasColumnName("courseName");

                entity.Property(e => e.GraduationDate)
                    .HasColumnType("date")
                    .HasColumnName("graduationDate");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<DepEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DepEmp");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.HasOne(d => d.Department)
                    .WithMany()
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepEmp_Departments");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepEmp_Employees");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("departmentID");

                entity.Property(e => e.DapartmentName)
                    .HasMaxLength(20)
                    .HasColumnName("dapartmentName");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("employeeID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(15)
                    .HasColumnName("firstName");

                entity.Property(e => e.Hired)
                    .HasColumnType("date")
                    .HasColumnName("hired");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .HasColumnName("lastName");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<StudCourse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StudCourse");

                entity.Property(e => e.CourseId).HasColumnName("courseID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.GradeDate)
                    .HasColumnType("date")
                    .HasColumnName("gradeDate");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.HasOne(d => d.Course)
                    .WithMany()
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudCourse_Courses");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudCourse_Employees");

                entity.HasOne(d => d.Student)
                    .WithMany()
                    .HasForeignKey(d => d.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StudCourse_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.StudentId)
                    .ValueGeneratedNever()
                    .HasColumnName("studentID");

                entity.Property(e => e.ClassId).HasColumnName("classID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(15)
                    .HasColumnName("firstName");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .HasColumnName("lastName");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Classes");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
