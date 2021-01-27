

namespace ExamSystem.DAL
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

        }

        public ICourseRepository Courses { get; private set; }

        public IQuestionRepository Questions { get; private set; }

        public IExamRepository Exams { get; private set; }

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