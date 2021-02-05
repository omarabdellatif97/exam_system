using ExamSystem.DAL.Core.Repositories;
using System;

namespace ExamSystem.DAL.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IQuestionRepository Questions { get; }
        IInstructorRepository Instructors { get; }
        IExamRepository Exams { get; }
        IStudentRepository Students { get; }
        int Complete();
    }
}