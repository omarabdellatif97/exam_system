using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class Student
    {
        public Student()
        {
            Exams = new HashSet<Exam>();
            StCrs = new HashSet<StCr>();
        }

        public int StId { get; set; }
        public int Ssn { get; set; }
        public string StName { get; set; }
        public DateTime BirthDate { get; set; }
        public string StEmail { get; set; }
        public string StHashedPwd { get; set; }
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<StCr> StCrs { get; set; }
    }
}
