using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.DAL
{
    public partial class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
            InsCrs = new HashSet<InsCr>();
        }

        public int InsId { get; set; }
        public string InsName { get; set; }
        public string InsEmail { get; set; }
        public string InsHashedPwd { get; set; }
        public int DeptId { get; set; }

        public virtual Department Dept { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<InsCr> InsCrs { get; set; }
    }
}
