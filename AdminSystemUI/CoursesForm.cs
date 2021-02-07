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
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
        }


        ExamContext ctxAllCourses = new ExamContext();
        ExamContext ctx = new ExamContext();
        List<Course> courses;
        
        List<Student> students;

        List<Instructor> instructors;
        
        //List<StCr> stdCrs;
        
        //List<InsCr> insCrs;






        private void CoursesForm_Load(object sender, EventArgs e)
        {

            this.FormClosed += (sender, e) =>
            {
                ctxAllCourses.Dispose();
                ctx.Dispose();
            };


            ctxAllCourses.Courses.Load();
            gridAllCourses.DataSource = ctxAllCourses.Courses.Local.ToBindingList();

            gridAllCourses.Columns["Exams"].Visible = false;
            gridAllCourses.Columns["InsCrs"].Visible = false;
            gridAllCourses.Columns["Questions"].Visible = false;
            gridAllCourses.Columns["CrsId"].Visible = false;


            using (ExamContext ctx = new ExamContext())
            {
                ctx.Courses.Load();
                ctx.Students.Load();
                ctx.Instructors.Load();
                //ctx.StCrs.Load();
                //ctx.InsCrs.Load();

                students = ctx.Students.Local.ToList();
                instructors = ctx.Instructors.Local.ToList();
                courses = ctx.Courses.Local.ToList();
                //stdCrs = ctx.StCrs.Local.ToList();
                //insCrs = ctx.InsCrs.Local.ToList();
            }
            



            //cmbStd.DataSource = ctx.Students.Local.ToList();
            cmbStd.DataSource = students;
            cmbStd.DisplayMember = "StName";
            cmbStd.ValueMember = "StId";
            cmbStd.SelectedIndex = 0;


            cmbCourse.DataSource = courses;
            cmbCourse.ValueMember = "CrsId";
            cmbCourse.DisplayMember = "CrsName";
            cmbCourse.SelectedIndex = 0;


            cmbInstructor.DataSource = instructors;
            cmbInstructor.DisplayMember = "InsName";
            cmbInstructor.ValueMember = "InsId";
            cmbInstructor.SelectedIndex = 0;

            cmbInsCourses.DataSource = courses;
            cmbInsCourses.ValueMember = "CrsId";
            cmbInsCourses.DisplayMember = "CrsName";
            cmbInsCourses.SelectedIndex = 0;






        }

        private void btnSaveCourses_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {


                    gridAllCourses.EndEdit();
                    ctxAllCourses.SaveChanges();
                    MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            
        }


        private void Reload()
        {
            
            using (ExamContext ctx = new ExamContext())
            {
                ctx.Courses.Load();
                ctx.Students.Load();
                ctx.Instructors.Load();
                //ctx.StCrs.Load();
                //ctx.InsCrs.Load();

                students = ctx.Students.Local.ToList();
                instructors = ctx.Instructors.Local.ToList();
                courses = ctx.Courses.Local.ToList();
                //stdCrs = ctx.StCrs.Local.ToList();
                //insCrs = ctx.InsCrs.Local.ToList();
            }




            //cmbStd.DataSource = ctx.Students.Local.ToList();
            cmbStd.DataSource = students;
            cmbCourse.DataSource = courses;
            cmbInstructor.DataSource = instructors;
            cmbInsCourses.DataSource = courses;

        }

        private void cmbStd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // assign student to course
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    using (var ctx = new ExamContext())
                    {
                        var st = cmbStd.SelectedItem as Student;
                        var cr = cmbCourse.SelectedItem as Course;

                        if(st != null && cr != null)
                        {
                            StCr cs = new StCr() { CrsId = cr.CrsId, StId = st.StId };

                            ctx.StCrs.Add(cs);
                            ctx.SaveChanges();
                            //stdCrs.Add(cs);

                        }


                    }



                    MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void btnCheckStdCrs_Click(object sender, EventArgs e)
        {
            try
            {
                var st = cmbStd.SelectedItem as Student;
                var cr = cmbCourse.SelectedItem as Course;


                if (ctx.StCrs.Count(c => c.StId == st.StId && c.CrsId == cr.CrsId) > 0)
                    lblStdState.Text = $"{st.StName} is Assigned to course {cr.CrsName}";
                else
                    lblStdState.Text = $"{st.StName} is Not Assigned to course {cr.CrsName}";


            }
            catch (Exception ex)
            {

            }
            

        }

        private void btnRemoveStdCrs_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    using (var ctx = new ExamContext())
                    {
                        var st = cmbStd.SelectedItem as Student;
                        var cr = cmbCourse.SelectedItem as Course;

                        if (st != null && cr != null)
                        {
                            StCr cs = new StCr() { CrsId = cr.CrsId, StId = st.StId };

                            ctx.StCrs.Remove(cs);
                            ctx.SaveChanges();
                            //stdCrs.Remove(cs);

                        }


                    }



                    MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }


        // form instructor 
        private void btnAssignInstructor_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    using (var ctx = new ExamContext())
                    {
                        var st = cmbInstructor.SelectedItem as Instructor;
                        var cr = cmbInsCourses.SelectedItem as Course;

                        if (st != null && cr != null)
                        {
                            InsCr cs = new InsCr() { CrsId = cr.CrsId, InsId = st.InsId };


                            ctx.InsCrs.Add(cs);
                            ctx.SaveChanges();
                            //insCrs.Add(cs);
                        }



                        MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        // form instructor 
        private void btnCheckAssign_Click(object sender, EventArgs e)
        {
            try
            {
                var st = cmbInstructor.SelectedItem as Instructor;
                var cr = cmbInsCourses.SelectedItem as Course;

                if (ctx.InsCrs.Count(c => c.InsId == st.InsId && c.CrsId == cr.CrsId) > 0)
                    lblInsState.Text = $"{st.InsName} teaches course {cr.CrsName}";
                else
                    lblInsState.Text = $"{st.InsName} doesn't teach course {cr.CrsName}";

            }
            catch (Exception ex)
            {

                            }
            
        }
        // form instructor 
        private void btnInstructorCrsRemove(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var ctx = new ExamContext())
                    {
                        var st = cmbInstructor.SelectedItem as Instructor;
                        var cr = cmbInsCourses.SelectedItem as Course;

                        if (st != null && cr != null)
                        {
                            InsCr cs = new InsCr() { CrsId = cr.CrsId, InsId = st.InsId };

                            ctx.InsCrs.Remove(cs);
                            ctx.SaveChanges();
                            //insCrs.Remove(cs);
                        }



                        MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        
    }
}
