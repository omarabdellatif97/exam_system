using ExamSystem.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystemUI
{
    public partial class QuestionSystemForm : Form
    {
        public QuestionSystemForm()
        {
            InitializeComponent();
        }

        readonly Question question = new Question();

        List<Course> courses;

        BindingList<Choice> choices;

        private void QuestionSystemForm_Load(object sender, EventArgs e)
        {
            choices = new BindingList<Choice>();

            grid.DataSource = choices;

            try
            {
                using (ExamContext ctx = new ExamContext())
                {

                    ctx.Courses.Load();
                    courses = ctx.Courses.Local.ToList();
                    cmbCourses.DataSource = courses;
                    cmbCourses.DisplayMember = "CrsName";
                    cmbCourses.ValueMember = "CrsId";




                    //public int CrsId { get; set; }
                    //public string CrsName { get; set; }
                    //public DateTime DateEnd { get; set; }
                    //public TimeSpan? ExamDuration { get; set; }
                    //public int? NumMcq { get; set; }


                    //public int? NumTorf { get; set; }
                    //public int ChoId { get; set; }
                    //public string ChoText { get; set; }
                    //public int State { get; set; }

                    //public virtual ICollection<ChoQue> ChoQues { get; set; }
                    //public virtual ICollection<QueInsCho> QueInsChos { get; set; }

                    grid.Columns["ChoId"].Visible = false;
                    grid.Columns["ChoQues"].Visible = false;
                    grid.Columns["QueInsChos"].Visible = false;


                    question.QueBody = "";
                    question.QueType = 0;

                    cmbCourses.SelectionChangeCommitted += (sender, e) =>
                    {
                        question.Crs = cmbCourses.SelectedItem as Course;
                        question.CrsId = question.Crs.CrsId;
                    };

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Load Quesiton system");
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (question.QueBody != null
                && txtQuestion.Text.Trim() != ""
                && choices.Count > 0)
            {
                ExamContext ctx;

                try
                {
                    if (numeric.Value > 1 && numeric.Value < 100)
                        question.Grade = 1;
                    else
                        question.Grade = (int)numeric.Value;

                    question.QueBody = txtQuestion.Text;
                    using (ctx = new ExamContext())
                    {
                        ctx.Questions.Add(question);
                        ctx.Choices.AddRange(choices);
                        ctx.SaveChanges();
                        ctx.ChoQues.AddRange(choices.Select(s => new ChoQue() { ChoId = s.ChoId, QueId = question.QueId }));
                        ctx.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("can't add question", "failed to add questions");

                }



            }
            else
                MessageBox.Show("can't add question", "failed to add questions");
        }
    }
}
