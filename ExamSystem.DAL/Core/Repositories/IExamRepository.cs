using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL.Core.Repositories
{
    public interface IExamRepository: IRepository<Exam>
    {
        int generateExam(Course course, Student student, int numOfMCQ, int numOfTORF, TimeSpan timeSpan);
        void submitExamAnswer(QuestionInstance QI, Choice ch);
        void correctExam(Exam exam);
        Exam GetExam(int id);
    }
}
