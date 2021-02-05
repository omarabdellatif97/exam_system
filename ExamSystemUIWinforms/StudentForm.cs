using ExamSystem.DAL.Models;
using ExamSystem.Systems;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExamSystemUIWinforms
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private StudentSystem sys;


        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ReloadForm();




        }

        private void ReloadForm()
        {
            lblStdId.Text = sys.Student.StId.ToString();
            lblStdName.Text = sys.Student.StName;
            lblStdEmail.Text = sys.Student.StEmail;
            lblStdSSN.Text = sys.Student.Ssn.ToString();
            lblStdBirth.Text = sys.Student.BirthDate.ToShortDateString();
            lblStdDept.Text = sys.Department.DeptName;


            sys.Courses.ForEach(c =>
            {
                AddCourse(c);
            });

        }



        internal void SetStudent(Student std)
        {
            sys = StudentSystem.LoadStudent(std);
            

            //this.tabStudent;


        }

        void AddCourse(Course course)
        {

            TableLayoutPanel tableLayoutPanel1 = new();
            Label label10 = new();
            Label label9 = new();
            Label label11 = new();
            Label label12 = new();
            Label label16 = new();
            Label label17 = new();
            Button btnStartExam = new();
            Label lblCrsId = new();
            Label lblCrsStartDate = new();
            Label lblCrsStatus = new();
            Label lblCrsName = new();
            Label lblCrsEndDate = new();


            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label12, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Controls.Add(label16, 2, 1);
            tableLayoutPanel1.Controls.Add(label17, 2, 2);
            tableLayoutPanel1.Controls.Add(btnStartExam, 2, 3);
            tableLayoutPanel1.Controls.Add(lblCrsId, 1, 1);
            tableLayoutPanel1.Controls.Add(lblCrsStartDate, 1, 2);
            tableLayoutPanel1.Controls.Add(lblCrsStatus, 1, 3);
            tableLayoutPanel1.Controls.Add(lblCrsName, 3, 1);
            tableLayoutPanel1.Controls.Add(lblCrsEndDate, 3, 2);
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel1.Size = new System.Drawing.Size(503, 201);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = System.Windows.Forms.DockStyle.Fill;
            label12.Location = new System.Drawing.Point(3, 150);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(104, 51);
            label12.TabIndex = 3;
            label12.Text = "YourStatus";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Location = new System.Drawing.Point(3, 100);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(104, 50);
            label10.TabIndex = 1;
            label10.Text = "Start Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Location = new System.Drawing.Point(3, 50);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(104, 50);
            label9.TabIndex = 0;
            label9.Text = "ID: ";
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label11, 4);
            label11.Location = new System.Drawing.Point(201, 11);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(101, 28);
            label11.TabIndex = 2;
            label11.Text = "C# Course";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(261, 50);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(73, 28);
            label16.TabIndex = 7;
            label16.Text = "Name: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(261, 100);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(91, 28);
            label17.TabIndex = 8;
            label17.Text = "End Date";
            // 
            // btnStartExam
            // 
            tableLayoutPanel1.SetColumnSpan(btnStartExam, 2);
            btnStartExam.Dock = System.Windows.Forms.DockStyle.Fill;
            btnStartExam.Location = new System.Drawing.Point(261, 153);
            btnStartExam.Name = "btnStartExam";
            btnStartExam.Size = new System.Drawing.Size(239, 45);
            btnStartExam.TabIndex = 9;
            btnStartExam.Text = "Start Exam";
            btnStartExam.UseVisualStyleBackColor = true;
            
            // 
            // lblCrsId
            // 
            lblCrsId.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCrsId.AutoSize = true;
            lblCrsId.Location = new System.Drawing.Point(153, 61);
            lblCrsId.Name = "lblCrsId";
            lblCrsId.Size = new System.Drawing.Size(61, 28);
            lblCrsId.TabIndex = 10;
            lblCrsId.Text = course.CrsId.ToString();
            // 
            // lblCrsStartDate
            // 
            lblCrsStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCrsStartDate.AutoSize = true;
            lblCrsStartDate.Location = new System.Drawing.Point(153, 111);
            lblCrsStartDate.Name = "lblCrsStartDate";
            lblCrsStartDate.Size = new System.Drawing.Size(61, 28);
            lblCrsStartDate.TabIndex = 11;
            lblCrsStartDate.Text = course.DateEnd.ToShortDateString();
            // 
            // lblCrsStatus
            // 
            lblCrsStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblCrsStatus.AutoSize = true;
            lblCrsStatus.Location = new System.Drawing.Point(153, 161);
            lblCrsStatus.Name = "lblCrsStatus";
            lblCrsStatus.Size = new System.Drawing.Size(61, 28);
            lblCrsStatus.TabIndex = 12;
            lblCrsStatus.Text = "Trail No 1";
            // 
            // lblCrsName
            // 
            lblCrsName.AutoSize = true;
            lblCrsName.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCrsName.Location = new System.Drawing.Point(358, 50);
            lblCrsName.Name = "lblCrsName";
            lblCrsName.Size = new System.Drawing.Size(142, 50);
            lblCrsName.TabIndex = 13;
            lblCrsName.Text = course.CrsName;
            // 
            // lblCrsEndDate
            // 
            lblCrsEndDate.AutoSize = true;
            lblCrsEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            lblCrsEndDate.Location = new System.Drawing.Point(358, 100);
            lblCrsEndDate.Name = "lblCrsEndDate";
            lblCrsEndDate.Size = new System.Drawing.Size(142, 50);
            lblCrsEndDate.TabIndex = 14;
            lblCrsEndDate.Text = course.DateEnd.ToShortDateString();

            // my logic

            foreach (var item in tableLayoutPanel1.Controls)
            {
                if(item is Label lb)
                    lb.Padding = new Padding(7);
            }
                

            this.flowPanelCourses.Controls.Add(tableLayoutPanel1);
        }
    }
}
