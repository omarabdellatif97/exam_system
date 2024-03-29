﻿using System;
using System.Text;
using System.Security.Cryptography;
using System.Linq;
using ExamSystem.DAL.Models;
using ExamSystem.DAL.Core.Repositories;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamSystem.DAL.Presistence.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ExamContext context)
            : base(context)
        {
        }
        public ExamContext ExamContext
        {
            get { return Context as ExamContext; }
        }

        public Student authenticate(string email, string password)
        {
            byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPwd = BitConverter.ToString(bytes).Replace("-", "");
            Student student = ExamContext.Students.FirstOrDefault(S => S.StHashedPwd == hashedPwd && S.StEmail == email);
            return student;
        }

        public IEnumerable<Course> GetCourses(int id)
        {
            var CrsStList = Context.Students.Include("StCrs").First(S => S.StId == id).StCrs.ToList();
            var CoursesList = Context.Courses.ToList();
            return CoursesList.Join(CrsStList, C => C.CrsId, SC => SC.CrsId, (C, SC) => C).ToList();
        }
    }



}
