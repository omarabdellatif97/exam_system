using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExamSystem.Systems;
using ExamSystem.DAL;
using ExamSystem.DAL.Models;


namespace ExamSystemUIWinforms
{
    public partial class ExamForm : Form
    {

        private ExaminationSystem sys;
        private ExamNavigator nav;

        public ExamForm()
        {
            InitializeComponent();
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadExam(null, null);

            


        }

        private void LoadExam(Student std, Course crs)
        {
            sys = ExaminationSystem.LoadExamTest();
            nav = new ExamNavigator(sys);


            lblTitle.Text = $"{sys.Student.StId} {sys.Student.StName}";

            lblTimer.Text = "Start Exam";

            nav.PositionChanged += (sender, e) =>
            {
                SetQuestion(e.Question);
            };



            //SetQuestion(sys.Questions[0]);
        }

        private void SetQuestion(ExamQuestion question)
        {
            lblQueNo.Text = $"{question.QueNo}- ";
            lblQueHader.Text = question.QueHeader;
            txtQueBody.Text = question.QueBody;

            flowChoices.Controls.Clear();


            switch (question.QueType)
            {
                case QuestionType.TrueFalse:
                    question.Choices.ForEach(c =>
                    {
                        RadioButton box = new RadioButton();
                        box.AutoSize = true;

                        if (question.StudentChoices.Contains(c))
                            box.Checked = true;

                        box.CheckedChanged += (sender, e) =>
                        {
                            if (box.Checked)
                                question.StudentChoices.Add(c);
                            else
                                question.StudentChoices.Remove(c);
                        };
                        box.Text = c.ChoText;
                        flowChoices.Controls.Add(box);
                    });

                    break;
                case QuestionType.MCQ:
                    question.Choices.ForEach(c =>
                    {



                        CheckBox box = new CheckBox();
                        box.AutoSize = true;
                        if (question.StudentChoices.Contains(c))
                            box.Checked = true;


                        box.CheckedChanged += (sender, e) =>
                        {
                            if (box.Checked)
                                question.StudentChoices.Add(c);
                            else
                                question.StudentChoices.Remove(c);
                        };
                        box.Text = c.ChoText;
                        flowChoices.Controls.Add(box);
                    });

                    break;
                default:
                    break;
            }


            


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nav.MoveNext();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            nav.MovePrevious();
        }




        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this,"Are You Sure Yoy Want to Submit Your Answers And Exit Exam?"
                ,"Submit Answer"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sys.SubmitAnswers();
            }
        }



        // Exam Navigation



    }
}
