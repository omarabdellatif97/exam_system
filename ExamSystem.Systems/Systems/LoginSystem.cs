using System;
using System.Collections.Generic;
using System.Text;
using ExamSystem.DAL;
using ExamSystem.DAL.Models;
using ExamSystem.DAL.Presistence;

namespace ExamSystem.Systems
{
    public class LoginSystem
    {

        private UnitOfWork context;

        // student or instructor
        public Student ValidateStudent(string user, string pass)
        {
           
            using (UnitOfWork unit = new UnitOfWork(new ExamContext()))
            {
                var std = unit.Students.authenticate(user, pass);
                if (std == null) return null;
                std.Dept = unit._Context.Departments.Find(std.DeptId);
                return std;
            }
        }

        public Instructor ValidateInstructor(string user, string pass)
        {
            using (UnitOfWork unit = new UnitOfWork(new ExamContext()))
            {
                var std = unit.Instructors.authenticate(user, pass);
                if (std == null) return null;
                std.Dept = unit._Context.Departments.Find(std.DeptId);
                return std;
            }
        }
    }
}
