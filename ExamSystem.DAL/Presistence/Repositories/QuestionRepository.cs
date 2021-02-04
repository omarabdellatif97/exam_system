using ExamSystem.DAL.Core.Repositories;
using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSystem.DAL.Presistence.Repositories
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
