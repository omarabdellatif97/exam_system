using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL
{
    class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(ExamContext context)
            : base(context)
        {
        }
        public ExamContext ExamContext
        {
            get { return Context as ExamContext; }
        }
    }


    
}
