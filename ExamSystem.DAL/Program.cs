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
                foreach (var crs in courses)
                {
                    Console.WriteLine(crs.CrsId);
                }


                var exam = unitOfWork.Exams.GetExam(7);
                foreach (var QI in exam.QuestionInstances)
                {
                    Console.WriteLine($"{QI.Que.QueBody}");
                    foreach (var cho in QI.Que.ChoQues) 
                    {
                        Console.WriteLine(cho.Cho.ChoText);
                    }
                }

                unitOfWork.Exams.correctExam(exam);
    

                var std = unitOfWork.Students.authenticate("moamensoroor@gmail.com", "12345678");
                Console.WriteLine(std.StId);


            }
        }

    }
}
