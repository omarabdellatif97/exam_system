using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class Choice
    {
        public Choice()
        {
            ChoQues = new HashSet<ChoQue>();
            QueInsChos = new HashSet<QueInsCho>();
        }

        public int ChoId { get; set; }
        public string ChoText { get; set; }
        public int State { get; set; }

        public virtual ICollection<ChoQue> ChoQues { get; set; }
        public virtual ICollection<QueInsCho> QueInsChos { get; set; }
    }
}
