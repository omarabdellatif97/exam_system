using ExamSystem.DAL.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.Systems
{
    public class ExaminationSystem
    {



        

        private Student student;
        private Department department;
        private Course course;

        private List<ExamQuestion> questions;


        public ExaminationSystem(Student std, Course course)
        {
            this.student = std;
            this.course = course;
            this.questions = new List<ExamQuestion>();
        }

        public Student Student { get => student; internal set => student = value; }
        public Department Department { get => department; internal set => department = value; }
        public Course Course { get => course; internal set => course = value; }
        public List<ExamQuestion> Questions { get => questions; internal set => questions = value; }
        public Exam Exam { get; internal set; }

        public void SubmitAnswers()
        {
            /// model context
            /// sumit
            //QuestionInstance e;
        }



        // db 
        public static ExaminationSystem LoadExam(Student std, Course course)
        {
            int choNO = 5;

            ExaminationSystem sys = new ExaminationSystem(std, course);
            Exam ex = new Exam();
            ex.ExamId = 10;
            ex.Date = DateTime.Now;
            ex.Duration = new TimeSpan(1, 0, 0);
            ex.TrialNo = 1;
            ex.StId = std.StId;
            ex.CrsId = course.CrsId;
            ex.Crs = course;
            ex.St = std;
            ex.Date = DateTime.Now;

            if ((course?.NumMcq ?? 0) > 0)
                sys.Questions.AddRange(Enumerable.Range(0, course?.NumMcq ?? 0)
                        .Select(i => new ExamQuestion()
                        {

                            QueNo = i + 1,
                            QueInsId = i + 1,
                            QueId = i + 1,
                            QueBody = $"body {i + 1} {"".PadLeft(new Random().Next(10, 100),'a')}",
                            Grade = 2,
                            QueType = QuestionType.MCQ,
                            ChoNo = choNO,
                            Choices = Enumerable.Range(0, choNO).Select(i =>

                                new Choice()
                                {
                                    ChoId = i + 1,
                                    ChoText = $"Choice {i}",
                                    State = new Random().Next(0, 1),

                                }
                            ).ToList()

                        }));


            if ((course?.NumTorf ?? 0) > 0)
                sys.Questions.AddRange(Enumerable.Range(0, course?.NumTorf ?? 0)
                        .Select(i => new ExamQuestion()
                        {

                            QueNo = i + 1,
                            QueInsId = i + 1,
                            QueId = i + 1,
                            QueBody = $"body {i + 1}",
                            Grade = 2,
                            QueType = QuestionType.TrueFalse,
                            ChoNo = choNO,
                            Choices = Enumerable.Range(0, 2).Reverse().Select(i =>

                                new Choice()
                                {
                                    ChoId = i + 1,
                                    ChoText = i == 1 ? "True" : "False",
                                    State = new Random().Next(0, 1),

                                }
                            ).ToList()

                        }));

            sys.Exam = ex;
            sys.Department = std.Dept;
            sys.Course = course;
            return sys;
        }


        // for test load

        public static ExaminationSystem LoadExamTest()
        {
            var std = new Student()
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


            StudentSystem stdSys = StudentSystem.LoadStudent(std);

            return LoadExam(std, stdSys.Courses[0]);
        }

    }
}
