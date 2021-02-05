using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Systems.Systems
{
    public class InstructorSystem
    {

        private Instructor instructor;

        private List<Course> courses;

        private Department department;


        public InstructorSystem(Instructor std)
        {
            this.instructor = std;
        }

        public Instructor Instructor { get => instructor; internal set => instructor = value; }


        public Department Department { get => department; internal set => department = value; }

        // current courses
        public List<Course> Courses { get => courses; internal set => courses = value; }


        public static InstructorSystem LoadInstructor(Instructor std)
        {
            InstructorSystem sys = new InstructorSystem(std);

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

            sys.Instructor = std;
            sys.Department = std.Dept;

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
