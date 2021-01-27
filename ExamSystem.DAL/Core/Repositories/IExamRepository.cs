using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL
{
    public interface IExamRepository: IRepository<Exam>
    {
        int generateExam(Course course, Student student, int numOfMCQ, int numOfTORF, TimeSpan timeSpan);
    }
}
