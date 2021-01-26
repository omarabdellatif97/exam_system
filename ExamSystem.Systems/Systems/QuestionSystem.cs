using System;
using System.Collections.Generic;
using System.Text;
using ExamSystem.DAL.Models;

namespace ExamSystem.Systems
{
    public class QuestionSystem
    {
        public int QueId { get; set; }
        public QuestionType QueType { get; set; }
        public int QueNo { get; set; }
        public string QueBody { get; set; }
        public double Grade { get; set; }
        public HashSet<Choice> Choices { get; set; }

    }
}
