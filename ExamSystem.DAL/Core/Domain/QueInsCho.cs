using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class QueInsCho
    {
        public int QueInsId { get; set; }
        public int ChoId { get; set; }

        public virtual Choice Cho { get; set; }
        public virtual QuestionInstance QueIns { get; set; }
    }
}
