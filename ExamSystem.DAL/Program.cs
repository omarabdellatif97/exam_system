using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using ExamSystem.DAL.Models;
using ExamSystem.DAL.Presistence;

namespace ExamSystem.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new ExamContext()))
            {

                //var student = unitOfWork.Students.authenticate("test@test.test", "12345678");
                var courses = unitOfWork.Students.GetCourses(6);
                var exam = unitOfWork.Exams.GetExam(7);
                foreach (var QI in exam.QuestionInstances)
                {
                    Console.WriteLine($"{QI.Que.QueBody}");
                    foreach (var cho in QI.Que.ChoQues) 
                    {
                        Console.WriteLine(cho.Cho.ChoText);
                    }
                }
                //var courses = unitOfWork.Courses.GetAll();
                //var course = unitOfWork.Courses.GetAll().First();
                //var student = unitOfWork._Context.Students.First();
                //int examID = unitOfWork.Exams.generateExam(course, student, 5, 0, new TimeSpan(1, 0, 0));
                //var exams = unitOfWork.Exams.GetAll();
                //Console.WriteLine(examID);
                //foreach (var exam in exams)
                //{
                //    Console.WriteLine(exam.ExamId);
                //}

                unitOfWork.Exams.correctExam(exam);
    

                var std = unitOfWork.Students.authenticate("moamensoroor@gmail.com", "12345678");
                Console.WriteLine(std.StId);

                //var crs = unitOfWork.Students.GetCourses(6);
                //Console.WriteLine(grade);
                //unitOfWork.
                //var courses = unitOfWork.Courses.GetAll();
                //var course = unitOfWork.Courses.GetAll().First();
                //var student = unitOfWork._Context.Students.First();
                //int examID = unitOfWork.Exams.generateExam(course, student, 5, 0, new TimeSpan(1, 0, 0));
                //var exams = unitOfWork.Exams.GetAll();
                //Console.WriteLine(examID);
                //foreach (var exam in exams)
                //{
                //    Console.WriteLine(exam.ExamId);
                //}

            }
        }

    }
}
