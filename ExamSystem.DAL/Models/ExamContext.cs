using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class ExamContext : DbContext
    {
        public ExamContext()
        {
        }

        public ExamContext(DbContextOptions<ExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChoQue> ChoQues { get; set; }
        public virtual DbSet<Choice> Choices { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<InsCr> InsCrs { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<QueInsCho> QueInsChos { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionInstance> QuestionInstances { get; set; }
        public virtual DbSet<StCr> StCrs { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;Database=Exam;Integrated Security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ChoQue>(entity =>
            {
                entity.HasKey(e => new { e.ChoId, e.QueId });

                entity.ToTable("Cho_Que");

                entity.Property(e => e.ChoId).HasColumnName("Cho_ID");

                entity.Property(e => e.QueId).HasColumnName("Que_ID");

                entity.HasOne(d => d.Cho)
                    .WithMany(p => p.ChoQues)
                    .HasForeignKey(d => d.ChoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cho_Que_Choice");

                entity.HasOne(d => d.Que)
                    .WithMany(p => p.ChoQues)
                    .HasForeignKey(d => d.QueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cho_Que_Question");
            });

            modelBuilder.Entity<Choice>(entity =>
            {
                entity.HasKey(e => e.ChoId);

                entity.ToTable("Choice");

                entity.Property(e => e.ChoId).HasColumnName("Cho_ID");

                entity.Property(e => e.ChoText)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Cho_Text");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.CrsId);

                entity.ToTable("Course");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.Property(e => e.CrsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Crs_Name");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("Date_End");

                entity.Property(e => e.ExamDuration).HasColumnName("Exam_Duration");

                entity.Property(e => e.NumMcq).HasColumnName("Num_MCQ");

                entity.Property(e => e.NumTorf).HasColumnName("Num_TORF");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("Department");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Dept_Name");

                entity.Property(e => e.MgrId).HasColumnName("Mgr_ID");

                entity.HasOne(d => d.Mgr)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.MgrId)
                    .HasConstraintName("FK_Department_Instructor");
            });

            modelBuilder.Entity<Exam>(entity =>
            {
                entity.ToTable("Exam");

                entity.Property(e => e.ExamId).HasColumnName("Exam_ID");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.StId).HasColumnName("St_ID");

                entity.Property(e => e.TrialNo).HasColumnName("Trial_No");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Course");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.Exams)
                    .HasForeignKey(d => d.StId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Exam_Student");
            });

            modelBuilder.Entity<InsCr>(entity =>
            {
                entity.HasKey(e => new { e.InsId, e.CrsId });

                entity.ToTable("Ins_Crs");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.InsCrs)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ins_Crs_Course");

                entity.HasOne(d => d.Ins)
                    .WithMany(p => p.InsCrs)
                    .HasForeignKey(d => d.InsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ins_Crs_Instructor");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("Instructor");

                entity.Property(e => e.InsId).HasColumnName("Ins_ID");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.InsEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Email");

                entity.Property(e => e.InsHashedPwd)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Hashed_Pwd")
                    .IsFixedLength(true);

                entity.Property(e => e.InsName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ins_Name");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Instructor_Department");
            });

            modelBuilder.Entity<QueInsCho>(entity =>
            {
                entity.HasKey(e => new { e.QueInsId, e.ChoId });

                entity.ToTable("Que_Ins_Cho");

                entity.Property(e => e.QueInsId).HasColumnName("Que_Ins_ID");

                entity.Property(e => e.ChoId).HasColumnName("Cho_ID");

                entity.HasOne(d => d.Cho)
                    .WithMany(p => p.QueInsChos)
                    .HasForeignKey(d => d.ChoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Que_Ins_Cho_Choice1");

                entity.HasOne(d => d.QueIns)
                    .WithMany(p => p.QueInsChos)
                    .HasForeignKey(d => d.QueInsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Que_Ins_Cho_Question_Instance");
            });

            modelBuilder.Entity<Question>(entity =>
            {
                entity.HasKey(e => e.QueId);

                entity.ToTable("Question");

                entity.Property(e => e.QueId).HasColumnName("Que_ID");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.Property(e => e.QueBody)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Que_Body");

                entity.Property(e => e.QueType).HasColumnName("Que_Type");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Course");
            });

            modelBuilder.Entity<QuestionInstance>(entity =>
            {
                entity.HasKey(e => e.QueInsId);

                entity.ToTable("Question_Instance");

                entity.Property(e => e.QueInsId).HasColumnName("Que_Ins_ID");

                entity.Property(e => e.ExamId).HasColumnName("Exam_ID");

                entity.Property(e => e.QueId).HasColumnName("Que_ID");

                entity.Property(e => e.QueNo).HasColumnName("Que_No");

                entity.HasOne(d => d.Exam)
                    .WithMany(p => p.QuestionInstances)
                    .HasForeignKey(d => d.ExamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Instance_Exam");

                entity.HasOne(d => d.Que)
                    .WithMany(p => p.QuestionInstances)
                    .HasForeignKey(d => d.QueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Question_Instance_Question");
            });

            modelBuilder.Entity<StCr>(entity =>
            {
                entity.HasKey(e => new { e.StId, e.CrsId });

                entity.ToTable("St_Crs");

                entity.Property(e => e.StId).HasColumnName("St_ID");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.Property(e => e.MaxGrade).HasColumnName("Max_Grade");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.StCrs)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_St_Crs_Course");

                entity.HasOne(d => d.St)
                    .WithMany(p => p.StCrs)
                    .HasForeignKey(d => d.StId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_St_Crs_Student");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StId);

                entity.ToTable("Student");

                entity.Property(e => e.StId).HasColumnName("St_ID");

                entity.Property(e => e.BirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Birth_Date");

                entity.Property(e => e.DeptId).HasColumnName("Dept_ID");

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.StEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("St_Email");

                entity.Property(e => e.StHashedPwd)
                    .IsRequired()
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("St_Hashed_Pwd")
                    .IsFixedLength(true);

                entity.Property(e => e.StName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("St_Name");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Student_Department");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(e => e.TopId);

                entity.ToTable("Topic");

                entity.Property(e => e.TopId).HasColumnName("Top_ID");

                entity.Property(e => e.CrsId).HasColumnName("Crs_ID");

                entity.Property(e => e.TopName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Top_Name");

                entity.HasOne(d => d.Crs)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.CrsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Topic_Course");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
