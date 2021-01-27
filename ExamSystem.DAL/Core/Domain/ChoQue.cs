using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class ChoQue
    {
        public int ChoId { get; set; }
        public int QueId { get; set; }

        public virtual Choice Cho { get; set; }
        public virtual Question Que { get; set; }
    }
}
