using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class Exam
    {
        public Exam()
        {
            QuestionInstances = new HashSet<QuestionInstance>();
        }

        public int ExamId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public int StId { get; set; }
        public int CrsId { get; set; }
        public int TrialNo { get; set; }

        public virtual Course Crs { get; set; }
        public virtual Student St { get; set; }
        public virtual ICollection<QuestionInstance> QuestionInstances { get; set; }
    }
}
