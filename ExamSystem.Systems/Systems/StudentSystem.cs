using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace ExamSystem.Systems
{
    public class StudentSystem
    {
        private Student student;

        private List<Course> courses;

        private Department department;


        public StudentSystem(Student std)
        {
            this.student = std;
        }

        public Student Student { get => student; internal set => student = value; }


        public Department Department { get => department; internal set => department = value; }
        
        // current courses
        public List<Course> Courses { get => courses; internal set => courses = value; }



        // id;
        public static StudentSystem LoadStudent(Student std)
        {
            StudentSystem sys = new StudentSystem(std);

            //sys.Student = new Student()
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

            sys.Student = std;
            sys.department = std.Dept;

            sys.Courses = new List<Course>()
            {
                new Course()
                {
                    CrsId = 1,
                    CrsName = "C#",
                    DateEnd = DateTime.Now.AddDays(7),
                    ExamDuration = TimeSpan.FromMinutes(5),
                    NumMcq = 5,
                    NumTorf = 5,
                },
                new Course()
                {
                    CrsId = 2,
                    CrsName = "Database",
                    DateEnd = DateTime.Now.AddDays(7),
                    ExamDuration = TimeSpan.FromMinutes(5),
                    NumMcq = 6,
                    NumTorf = 6,
                },
                new Course()
                {
                    CrsId = 3,
                    CrsName = "CST",
                    DateEnd = DateTime.Now.AddDays(7),
                    ExamDuration = TimeSpan.FromMinutes(5),
                    NumMcq = 6,
                    NumTorf = 6
                },
            };




            return sys;

        }






    }
}
