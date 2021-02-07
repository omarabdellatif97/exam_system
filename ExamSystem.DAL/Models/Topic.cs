using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class Topic
    {
        public int TopId { get; set; }
        public string TopName { get; set; }
        public int CrsId { get; set; }

        public virtual Course Crs { get; set; }
    }
}
