using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.DAL.Models
{
    public partial class ExamContext : DbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Question>()
            //.HasKey(a => new { a.QueId, a.CrsId });
            //builder.Entity<RepeatOrderSummaryView>().HasNoKey();
            //modelBuilder.Entity<Question>().HasKey(Q => new { Q.QueId, Q.CrsId });

            //modelBuilder.Entity<Question>()
            //.HasKey(a => new { a.QueId, a.CrsId });
            //modelBuilder.Entity<Question>()
            //    .Property(p => p.QueId)
            //    .ValueGeneratedOnAdd().UseIdentityColumn();

            //modelBuilder.Entity<Question>()
            //    .Property(t => t.QueId)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //modelBuilder.Entity<Question>()
            //.Property(f => f.QueId)
            //.ValueGeneratedOnAdd();
        }

    }
}
