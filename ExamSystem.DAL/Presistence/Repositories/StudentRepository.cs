using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL
{
    class StudentRepository : Repository<Student>, IStudentRepository
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
            
            throw new NotImplementedException();
        }
    }



}
