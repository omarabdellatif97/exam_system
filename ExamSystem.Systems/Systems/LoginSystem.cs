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
            if(user.Equals("moa") && pass.Equals("moa"))
            {
                //return new Student()
                //{
                //    StId = 1234,
                //    Ssn = 12345567,
                //    BirthDate = DateTime.Now,
                //    StName = "Moamen Soroor",
                //    StEmail = "moamensoroor@gmail.com",
                //    Dept = new Department()
                //    {
                //        DeptId = 1,
                //        DeptName = "Management"
                //    },
                //    DeptId = 1,

                //};


                using(UnitOfWork unit = new UnitOfWork(new ExamContext()))
                {
                    var std = unit.Students.Get(6);
                    std.Dept = unit._Context.Departments.Find(std.DeptId);
                    return std;
                }


            }
            return null;

        }

        public Instructor ValidateInstructor(string user, string pass)
        {
            if (user.Equals("moa") && pass.Equals("moa"))
            {
                return new Instructor()
                {
                    InsId = 1234,
                    InsEmail = "moamensoroor@gmail.com",
                    InsName = "Moamen Soroor",
                    Dept = new Department()
                    {
                        DeptId = 1,
                        DeptName = "Management"
                    },
                    DeptId = 1,

                };


            }
            return null;
        }
    }
}
