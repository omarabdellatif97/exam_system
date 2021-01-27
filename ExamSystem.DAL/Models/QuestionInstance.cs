using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class QuestionInstance
    {
        public QuestionInstance()
        {
            QueInsChos = new HashSet<QueInsCho>();
        }

        public int QueInsId { get; set; }
        public int QueNo { get; set; }
        public int QueId { get; set; }
        public int ExamId { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual Question Que { get; set; }
        public virtual ICollection<QueInsCho> QueInsChos { get; set; }
    }
}
