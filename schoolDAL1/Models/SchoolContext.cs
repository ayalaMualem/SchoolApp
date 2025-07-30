using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Entities;
namespace schoolDAL.Models;

public partial class SchoolContext : DbContext
{
    public SchoolContext()
    {
    }

    public SchoolContext(DbContextOptions<SchoolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HomeroomTeacherOfClass> HomeroomTeacherOfClasses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherOfSubjectInClass> TeacherOfSubjectInClasses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\a0548\\Documents\\studies\\second_year\\c#\\summary_project\\School.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HomeroomTeacherOfClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HomeroomTeacherOfClass");

            entity.Property(e => e.Class).HasColumnType("VARCHAR(10)");
            entity.Property(e => e.IdTeacher).HasColumnType("INT");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("ID");
            entity.Property(e => e.Address).HasColumnType("VARCHAR(100)");
            entity.Property(e => e.BirthdayYear).HasColumnType("INT");
            entity.Property(e => e.Class).HasColumnType("VARCHAR(10)");
            entity.Property(e => e.FirstName).HasColumnType("VARCHAR(50)");
            entity.Property(e => e.HomePhone).HasColumnType("VARCHAR(20)");
            entity.Property(e => e.LastName).HasColumnType("VARCHAR(50)");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("ID");
            entity.Property(e => e.SubjectName).HasColumnType("VARCHAR(10)");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("INT")
                .HasColumnName("ID");
            entity.Property(e => e.FirstName).HasColumnType("VARCHAR(50)");
            entity.Property(e => e.LastName).HasColumnType("VARCHAR(50)");
            entity.Property(e => e.MailAddress).HasColumnType("VARCHAR(100)");
            entity.Property(e => e.Phone).HasColumnType("VARCHAR(20)");
        });

        modelBuilder.Entity<TeacherOfSubjectInClass>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.ToTable("TeacherOfSubjectInClass");

            entity.Property(e => e.Class).HasColumnType("VARCHAR(10)");
            entity.Property(e => e.IdSubject).HasColumnType("INT");
            entity.Property(e => e.IdTeacher).HasColumnType("INT");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
