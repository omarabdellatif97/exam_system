using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class Course
    {
        public Course()
        {
            Exams = new HashSet<Exam>();
            InsCrs = new HashSet<InsCr>();
            Questions = new HashSet<Question>();
        }

        public int CrsId { get; set; }
        public string CrsName { get; set; }
        public DateTime DateEnd { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<InsCr> InsCrs { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
