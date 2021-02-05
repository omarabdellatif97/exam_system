using System;
using System.Collections.Generic;
using System.Text;
using ExamSystem.DAL.Models;

namespace ExamSystem.Systems
{
    public class ExamQuestion
    {
        public int QueId { get; internal set; }
        public int QueInsId { get; internal set; }
        public QuestionType QueType { get; internal set; }
        public string QueHeader
        {
            get
            {
                switch (QueType)
                {
                    case QuestionType.TrueFalse:
                        return "Choose True Or False";
                    case QuestionType.MCQ:
                        return "Choose All True";
                    default:
                        return "Choose";
                }
            }
        }
        public int QueNo { get; internal set; }
        public string QueBody { get; internal set; }
        public double Grade { get; internal set; }
        public int ChoNo { get; internal set; }
        public List<Choice> Choices { get; internal set; }

        public List<Choice> StudentChoices { get; internal set; }

        public ExamQuestion()
        {
            Choices = new List<Choice>();
            StudentChoices = new List<Choice>();
        }


        




    }
}
