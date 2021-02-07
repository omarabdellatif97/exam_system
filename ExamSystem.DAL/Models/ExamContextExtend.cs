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
            //builder.Entity<RepeatOrderSummaryView>().HasNoKey();
            //modelBuilder.Entity<Question>().HasKey(Q => new { Q.QueId, Q.CrsId });
        }

    }
}
