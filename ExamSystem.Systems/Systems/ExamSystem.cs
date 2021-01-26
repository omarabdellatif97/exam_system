using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Systems
{
    class ExamSystem
    {

        private Student student;
        private Department department;
        private Course course;

        private int examId;
        private DateTime date;
        private TimeSpan duration;
        private int trialNo;


        public ExamSystem(Student std, Course course)
        {
            this.student = std;
            this.course = course;
        }

        public Student Student { get => student; set => student = value; }
        public Department Department { get => department; set => department = value; }
        public Course Course { get => course; set => course = value; }



        public void SubmitAnswers()
        {
            /// model context
            /// sumit
            //QuestionInstance e;
        }



        // db 
        public static ExamSystem GenerateExam(Student std, Course course)
        {

            Exam ex = new Exam();
            ex.ExamId = 10;
            ex.Date = DateTime.Now;
            ex.Duration = new TimeSpan(1, 0, 0);
            ex.TrialNo = 1;
            ex.StId = std.StId;
            ex.CrsId = course.CrsId;
            
            

            return new ExamSystem(std,course);
        }


    }
}
