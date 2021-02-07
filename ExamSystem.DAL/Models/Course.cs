using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class Course
    {
        public Course()
        {
            Exams = new HashSet<Exam>();
            InsCrs = new HashSet<InsCr>();
            Questions = new HashSet<Question>();
            StCrs = new HashSet<StCr>();
            Topics = new HashSet<Topic>();
        }

        public int CrsId { get; set; }
        public string CrsName { get; set; }
        public DateTime DateEnd { get; set; }
        public TimeSpan? ExamDuration { get; set; }
        public int? NumMcq { get; set; }
        public int? NumTorf { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<InsCr> InsCrs { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<StCr> StCrs { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}
