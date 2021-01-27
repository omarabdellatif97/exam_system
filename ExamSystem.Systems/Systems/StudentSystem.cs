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

        private List<Exam> exams;

        private Department department;


        public StudentSystem()
        {

        }

        public Student Student { get => student; set => student = value; }
        public Department Department { get => department; set => department = value; }
        public List<Course> Courses { get => courses; set => courses = value; }
        public List<Exam> Exams { get => exams; set => exams = value; }


        // id;
        public static StudentSystem LoadStudent(int id)
        {
            StudentSystem sys = new StudentSystem();


            return null;

        }






    }
}
