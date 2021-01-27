using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


namespace ExamSystem.DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new ExamContext()))
            {
                var courses = unitOfWork.Courses.GetAll();
                var course = unitOfWork.Courses.GetAll().First();
                var student = unitOfWork._Context.Students.First();
                int examID = unitOfWork.Exams.generateExam(course, student, 5, 0, new TimeSpan(1, 0, 0));
                var exams = unitOfWork.Exams.GetAll();
                Console.WriteLine(examID);
                foreach (var exam in exams)
                {
                    Console.WriteLine(exam.ExamId);
                }

            }
        }

    }
}
