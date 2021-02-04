using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamSystem.DAL.Core.Repositories
{
    public interface IInstructorRepository:IRepository<Instructor>
    {
        public Instructor authenticate(string email, string password);
    }
}
