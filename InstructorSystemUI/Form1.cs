using ExamSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamSystem.DAL.Presistence.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace InstructorSystemUI
{
    public partial class Form1 : Form
    {
        BindingSource stuBindingSource = new BindingSource();
        BindingSource deptBindingSource = new BindingSource();
        BindingSource instBindingSource = new BindingSource();
        BindingSource crsBindingSource = new BindingSource();
        BindingSource queBindingSource = new BindingSource();
        ExamContext examcontext = new ExamContext();
        public Form1()
        {
            InitializeComponent();


            examcontext.Students.Load();
            examcontext.Departments.Load();
            examcontext.Instructors.Load();
            examcontext.Courses.Include("Questions").Load();
            //examcontext.Questions.Load();
            var test = examcontext.Courses.Local.ToBindingList();
            stuBindingSource = new BindingSource(examcontext.Students.Local.ToBindingList(), "");
            deptBindingSource = new BindingSource(examcontext.Departments.Local.ToBindingList(), "");
            instBindingSource = new BindingSource(examcontext.Instructors.Local.ToBindingList(), "");


            crsBindingSource.DataSource = examcontext.Courses.Local.ToBindingList();
            crsBindingSource.DataMember = "";

            queBindingSource.DataSource = crsBindingSource;
            queBindingSource.DataMember = "Questions";
            //queBindingSource.DataMember = "Questions";

            stuBindingSource.AddingNew += (sender, e) =>
            {
                e.NewObject = new Student() { DeptId = examcontext.Departments.First().DeptId };
            };

            instBindingSource.AddingNew += (sender, e) =>
            {
                e.NewObject = new Instructor() { DeptId = examcontext.Departments.First().DeptId };
            };

            dataGridView1.DataSource = stuBindingSource;
            dataGridView1.Columns["StID"].ReadOnly = true;
            //dataGridView1.Columns["StID"].
            dataGridView1.Columns["Dept"].Visible = false;
            dataGridView1.Columns["Exams"].Visible = false;
            dataGridView1.Columns["StCrs"].Visible = false;
            dataGridView1.Columns["DeptId"].Visible = false;


            comboCourse.DataSource = crsBindingSource;
            comboCourse.DisplayMember = "CrsName";

            dataGridView4.DataSource = queBindingSource;

            //textQuestion.DataBindings.Add("Text", queBindingSource, "QueBody", true);

            DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
            DC.HeaderText = "Department";
            dataGridView1.Columns.AddRange(DC);
            DC.DataPropertyName = "DeptId";
            DC.DataSource = deptBindingSource;
            DC.ValueMember = "DeptId";
            DC.DisplayMember = "DeptName";
           


            dataGridView2.DataSource = instBindingSource;
            dataGridView2.Columns["Departments"].Visible = false;
            dataGridView2.Columns["Dept"].Visible = false;
            dataGridView2.Columns["InsCrs"].Visible = false;
            dataGridView2.Columns["DeptId"].Visible = false;
            dataGridView2.Columns["InsId"].Visible = false;
            DataGridViewComboBoxColumn DC2 = new DataGridViewComboBoxColumn();
            DC2.HeaderText = "Department";
            dataGridView2.Columns.AddRange(DC2);
            DC2.DataSource = deptBindingSource;
            DC2.ValueMember = "DeptId";
            DC2.DisplayMember = "DeptName";
            DC2.DataPropertyName = "DeptId";

            dataGridView3.DataSource = deptBindingSource;
            DataGridViewComboBoxColumn DC3 = new DataGridViewComboBoxColumn();
            DC3.HeaderText = "Manager";
            dataGridView3.Columns.AddRange(DC3);
            DC3.DataSource = instBindingSource;
            DC3.ValueMember = "InsId";
            DC3.DisplayMember = "InsName";
            DC3.DataPropertyName = "MgrId";
        }

        private void dataGridView1_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "StHashedPwd")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            // Map what the user typed into UTC.
                            byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(e.Value.ToString()));
                            string hashedPwd = BitConverter.ToString(bytes).Replace("-", "");
                            e.Value = hashedPwd;
                            e.ParsingApplied = true;
                        }
                        catch (FormatException)
                        {
                            // Set to false in case another CellParsing handler
                            // wants to try to parse this DataGridViewCellParsingEventArgs instance.
                            e.ParsingApplied = false;
                        }
                    }
                    //bindingSource.ResetCurrentItem();
                    //bindingSource.ResetBindings(false);
                    Trace.WriteLine("BeforeChanged");
                }
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "StHashedPwd" && e.Value != null)
            {
                e.Value = new String('\u25CF', 8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            examcontext.SaveChanges();
            queBindingSource.ResetBindings(false);
            
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "InsHashedPwd" && e.Value != null)
            {
                e.Value = new String('\u25CF', 8);
            }
        }

        private void dataGridView2_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "InsHashedPwd")
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            // Map what the user typed into UTC.
                            byte[] bytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(e.Value.ToString()));
                            string hashedPwd = BitConverter.ToString(bytes).Replace("-", "");
                            e.Value = hashedPwd;
                            e.ParsingApplied = true;
                        }
                        catch (FormatException)
                        {
                            // Set to false in case another CellParsing handler
                            // wants to try to parse this DataGridViewCellParsingEventArgs instance.
                            e.ParsingApplied = false;
                        }
                    }
                    //bindingSource.ResetCurrentItem();
                    //bindingSource.ResetBindings(false);
                    Trace.WriteLine("BeforeChanged");
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            queBindingSource.MoveNext();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            queBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            queBindingSource.AddNew();
        }
    }
}
