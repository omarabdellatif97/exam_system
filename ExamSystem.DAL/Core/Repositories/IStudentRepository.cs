using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL.Core.Repositories
{
    public interface IStudentRepository: IRepository<Student>
    {
        public Student authenticate(string email, string password);
    }
}
