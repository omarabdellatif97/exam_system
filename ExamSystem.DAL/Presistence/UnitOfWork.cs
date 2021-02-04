

using ExamSystem.DAL.Core;
using ExamSystem.DAL.Core.Repositories;
using ExamSystem.DAL.Models;
using ExamSystem.DAL.Presistence.Repositories;

namespace ExamSystem.DAL.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ExamContext _context;

        public ExamContext _Context { get { return _context; } }

        public UnitOfWork(ExamContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Questions = new QuestionRepository(_context);
            Exams = new ExamRepository(_context);
            Students = new StudentRepository(_context);

        }

        public IInstructorRepository Instructors { get; private set; }
        public ICourseRepository Courses { get; private set; }

        public IQuestionRepository Questions { get; private set; }

        public IExamRepository Exams { get; private set; }

        public IStudentRepository Students { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}