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
    public partial class StudentsForm : Form
    {
        public StudentsForm()
        {
            InitializeComponent();
        }



        ExamContext ctx = new ExamContext();

        DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
        BindingList<Student> stdList;
        BindingList<Department> deptList;

        BindingSource stdBinding;
        BindingSource deptBinding;

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) =>
            {
                ctx.Dispose();
            };



            ctx.Students.Load();
            ctx.Departments.Load();
            stdList = ctx.Students.Local.ToBindingList();
            deptList = ctx.Departments.Local.ToBindingList();

            stdBinding = new BindingSource(stdList, "");
            deptBinding = new BindingSource(deptList, "");


            grid.DataSource = stdBinding;
            


            //public int StId { get; set; }
            //public int Ssn { get; set; }
            //public string StName { get; set; }
            //public DateTime BirthDate { get; set; }
            //public string StEmail { get; set; }
            //public string StHashedPwd { get; set; }
            //public int DeptId { get; set; }

            //public virtual Department Dept { get; set; }
            //public virtual ICollection<Exam> Exams { get; set; }
            //public virtual ICollection<StCr> StCrs { get; set; }



            grid.Columns["StId"].Visible = false;
            grid.Columns["StHashedPwd"].Visible = false;
            grid.Columns["Exams"].Visible = false;
            grid.Columns["StCrs"].Visible = false;
            grid.Columns["Dept"].Visible = false;



            //    public int DeptId { get; set; }
            //public string DeptName { get; set; }

            DC.HeaderText = "Departments";

            // must be moved from here not to add again when reload
            grid.Columns.AddRange(DC);

            //DC.DataSource = pubList;
            DC.DataSource = deptBinding;


            DC.DisplayMember = "DeptName";
            DC.ValueMember = "DeptId";
            DC.DataPropertyName = "DeptId";



            stdBinding.AddingNew += (sender, e) =>
            {
                e.NewObject = new Student()
                {
                    DeptId = deptList.FirstOrDefault()?.DeptId??0,
                };
            };

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure you Want To Save Changes",
                    "Save Your Changes", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {


                    grid.EndEdit();
                    ctx.SaveChanges();


                    MessageBox.Show("Operation Done Successfully.", "Success Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception in Save Changes ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
