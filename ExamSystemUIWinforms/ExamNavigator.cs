using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamSystem.Systems;
using ExamSystem.DAL;
using ExamSystem.DAL.Models;

namespace ExamSystemUIWinforms
{
    public class ExamNavigator
    {

        public ExamNavigator(ExaminationSystem sys)
        {
            if (sys == null || sys.Questions.Count < 1)
                throw new Exception("not valid Exam system to navigate else system is null or quesions not exist");

            ExamSystem = sys;
            //Current = sys.Questions[0];
        }

        public ExaminationSystem ExamSystem { get; set; }


        public ExamQuestion Current { get; set; }
        public int Position { get; set; } = -1;


        public event EventHandler<PositionChangedEventArgs> PositionChanged;

        protected void OnPositionChanged(object sender, PositionChangedEventArgs e)
        {
            PositionChanged?.Invoke(sender, e);
        }



        public bool MoveNext()
        {
            if (Position < ExamSystem.Questions.Count - 1)
            {
                Position++;
                Current = ExamSystem.Questions[Position];
                OnPositionChanged(this, new PositionChangedEventArgs(Position,Current));
                return true;
            }
            else
                return false;
        }

        public bool MovePrevious()
        {
            if (Position > 0)
            {
                Position--;
                Current = ExamSystem.Questions[Position];
                OnPositionChanged(this, new PositionChangedEventArgs(Position,Current));
                return true;
            }
            else
                return false;
        }

        public bool MoveFirst()
        {
            if (ExamSystem.Questions.Count > 0 )
            {
                Position = 0;
                Current = ExamSystem.Questions[0];
                OnPositionChanged(this, new PositionChangedEventArgs(Position,Current));
                return true;
            }
            else
                return false;
        }

        public bool MoveLast()
        {
            if (ExamSystem.Questions.Count > 0)
            {
                Position = ExamSystem.Questions.Count - 1;
                Current = ExamSystem.Questions[Position];
                OnPositionChanged(this, new PositionChangedEventArgs(Position,Current));
                return true;
            }
            else
                return false;
        }

    }


    public class PositionChangedEventArgs: EventArgs
    {
        public int Position { get; }
        public ExamQuestion Question;

        public PositionChangedEventArgs(int pos, ExamQuestion question)
        {
            Position = pos;
            Question = question;
        }


    }
}
