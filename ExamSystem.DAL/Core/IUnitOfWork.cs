using System;

namespace ExamSystem.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IQuestionRepository Questions { get; }
        int Complete();
    }
}