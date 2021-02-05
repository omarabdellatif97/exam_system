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
using ExamSystem.Systems.Systems;

namespace ExamSystemUIWinforms
{
    public partial class InstructorPanelForm : Form
    {
        public InstructorPanelForm()
        {
            InitializeComponent();
        }

        private InstructorSystem sys;

        private bool isLoaded = false;

        //private readonly List<CourseBox> CourseBoxes = new List<CourseBox>();


        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //ReloadForm();




        }

        private void LoadForm()
        {
            if (isLoaded == true)
            {
                return;

            }
            lblStdId.Text = sys.Instructor.InsId.ToString();
            lblStdName.Text = sys.Instructor.InsName;
            lblStdEmail.Text = sys.Instructor.InsEmail;
            lblStdDept.Text = sys.Department.DeptName;
            isLoaded = true;
        }

        internal void SetInstructor(Instructor std)
        {
            sys = InstructorSystem.LoadInstructor(std);
            LoadForm();


        }

    }
}
