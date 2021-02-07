using ExamSystem.DAL.Models;
using ExamSystem.DAL.Presistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


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

            using(var ctx = new ExamContext())
            {
                sys.Instructor = std;
                sys.Department = std.Dept;

                var result = from c in ctx.Courses
                             join ci in ctx.InsCrs
                             on c.CrsId equals ci.CrsId
                             where ci.InsId.Equals(sys.instructor)
                             select c;


                sys.courses = result.ToList();
            }

            


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
