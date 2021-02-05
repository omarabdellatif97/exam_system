using ExamSystem.DAL.Core.Repositories;
using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ExamSystem.DAL.Presistence.Repositories
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ExamContext context)
            : base(context)
        {
        }
        public ExamContext ExamContext
        {
            get { return Context as ExamContext; }
        }

        public Instructor authenticate(string email, string password)
        {
            byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            string hashedPwd = BitConverter.ToString(bytes).Replace("-", "");
            Instructor instructor = ExamContext.Instructors.FirstOrDefault(I => I.InsHashedPwd == hashedPwd && I.InsEmail == email);
            return instructor;
        }
    }
}
