using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class Department
    {
        public Department()
        {
            Instructors = new HashSet<Instructor>();
            Students = new HashSet<Student>();
        }

        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public int? MgrId { get; set; }

        public virtual Instructor Mgr { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
