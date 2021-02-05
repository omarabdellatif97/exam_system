using ExamSystem.DAL.Models;
using ExamSystem.DAL.Presistence;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Diagnostics;

namespace ExamSystem.Systems
{
    public class StudentSystem
    {
        

        public StudentSystem(Student std)
        {
            this.student = std;
        }


        private Student student;

        private List<Course> courses;

        private Department department;


        public Student Student { get => student; internal set => student = value; }


        public Department Department { get => department; internal set => department = value; }

        // current courses
        public List<Course> Courses { get => courses; internal set => courses = value; }

        public List<Exam> Exams { get; set; }


        public int MaxTrial { get; internal set; }

        


        #region Old
        //id;
        //public static StudentSystem LoadStudent(Student std)
        //{

        //    StudentSystem sys = new StudentSystem(std);

        //    //sys.Student = new Student()
        //    //{
        //    //    StId = 1234,
        //    //    Ssn = 12345567,
        //    //    BirthDate = DateTime.Now,
        //    //    StName = "Moamen Soroor",
        //    //    StEmail = "moamensoroor@gmail.com",
        //    //    Dept = new Department()
        //    //    {
        //    //        DeptId = 1,
        //    //        DeptName = "Management"
        //    //    },
        //    //    DeptId = 1,

        //    //};

        //    sys.Student = std;
        //    sys.department = std.Dept;

        //    sys.Courses = new List<Course>()
        //    {
        //        new Course()
        //        {
        //            CrsId = 1,
        //            CrsName = "C#",
        //            DateEnd = DateTime.Now.AddDays(7),
        //            ExamDuration = TimeSpan.FromMinutes(5),
        //            NumMcq = 5,
        //            NumTorf = 5,
        //        },
        //        new Course()
        //        {
        //            CrsId = 2,
        //            CrsName = "Database",
        //            DateEnd = DateTime.Now.AddDays(7),
        //            ExamDuration = TimeSpan.FromMinutes(5),
        //            NumMcq = 6,
        //            NumTorf = 6,
        //        },
        //        new Course()
        //        {
        //            CrsId = 3,
        //            CrsName = "CST",
        //            DateEnd = DateTime.Now.AddDays(7),
        //            ExamDuration = TimeSpan.FromMinutes(5),
        //            NumMcq = 6,
        //            NumTorf = 6
        //        },
        //    };




        //    return sys;

        //}

        #endregion


        #region load student from db
        public static StudentSystem LoadStudent(Student std)
        {
            StudentSystem sys = new StudentSystem(std);
            try
            {
                using (UnitOfWork context = new UnitOfWork(new ExamContext()))
                {

                    sys.courses = context.Students.GetCourses(std.StId).ToList();

                    sys.Exams = context.Exams.Find(e => e.StId.Equals(std.StId)).ToList();

                    sys.MaxTrial = 5;
                    
                    sys.Department = std.Dept;
                    


                    //context.Complete();
                    return sys;

                }
            }
            catch (Exception ex)
            {
                // log exception

                Debug.WriteLine(ex.Message);
            }

            return sys;
            
        }
        #endregion


    }
}
