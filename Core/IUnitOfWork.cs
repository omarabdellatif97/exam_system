using System;

namespace DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IQuestionRepository Questions { get; }
        int Complete();
    }
}