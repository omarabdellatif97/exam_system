using System;
using System.Collections.Generic;
using System.Text;
using ExamSystem.DAL;
using ExamSystem.DAL.Models;


namespace ExamSystem.Systems
{
    public class LoginSystem
    {

        private UnitOfWork access;

        // student or instructor
        public Student ValidateStudent(string user, string pass)
        {
            if(user.Equals("moa") && pass.Equals("moa"))
            {
                return new Student()
                {
                    StId = 1234,
                    Ssn = 12345567,
                    BirthDate = DateTime.Now,
                    StName = "Moamen Soroor",
                    StEmail = "moamensoroor@gmail.com",
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
