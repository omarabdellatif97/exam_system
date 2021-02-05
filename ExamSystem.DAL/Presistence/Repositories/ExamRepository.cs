using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.DAL.Models;
using ExamSystem.DAL.Core.Repositories;

namespace ExamSystem.DAL.Presistence.Repositories
{
    class ExamRepository : Repository<Exam>, IExamRepository
    {
        public ExamRepository(ExamContext context)
           : base(context)
        {
        }
        public ExamContext ExamContext
        {
            get { return Context as ExamContext; }
        }

        public int generateExam(Course course, Student student, int numOfMCQ, int numOfTORF, TimeSpan timeSpan)
        {
            var ExamID = new SqlParameter
            {
                ParameterName = "@ExamID",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output,
            };
            var Crs_ID = new SqlParameter
            {
                ParameterName = "@Crs_ID",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
                Value = course.CrsId
            };
            var St_ID = new SqlParameter
            {
                ParameterName = "@St_ID",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
                Value = student.StId
            };
            var n1 = new SqlParameter
            {
                ParameterName = "@n1",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
                Value = numOfMCQ
            };
            var n2 = new SqlParameter
            {
                ParameterName = "@n2",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Input,
                Value = numOfTORF
            };
            
            var Duration = new SqlParameter
            {
                ParameterName = "@Duration",
                SqlDbType = System.Data.SqlDbType.Time,
                Direction = System.Data.ParameterDirection.Input,
                Value = timeSpan
            };
            Console.WriteLine(Duration.Value);
            //return 0;
            Context.Database.ExecuteSqlRaw("EXEC Generate_Exam @Crs_ID, @St_ID, @n1, @n2, @Duration, @examID output", Crs_ID, St_ID, n1, n2, Duration, ExamID);
            return (int)ExamID.Value;

        }

        public void submitExamAnswer(QuestionInstance QI, Choice ch)
        {
            throw new NotImplementedException();
        }
    }
}
