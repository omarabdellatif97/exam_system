using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL.Models
{
    public partial class StCr
    {
        public int StId { get; set; }
        public int CrsId { get; set; }
        public double? Grade { get; set; }
        public double? MaxGrade { get; set; }

        public virtual Course Crs { get; set; }
        public virtual Student St { get; set; }
    }
}
