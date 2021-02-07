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
    public partial class DepartmentsForm : Form
    {
        public DepartmentsForm()
        {
            InitializeComponent();
        }

        ExamContext ctx = new ExamContext();
        BindingList<Department> deptList;
        BindingSource deptBinding;

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) =>
            {
                ctx.Dispose();
            };



            ctx.Departments.Load();
            deptList = ctx.Departments.Local.ToBindingList();
            deptBinding = new BindingSource(deptList, "");



            // we should add first datasource on grid
            grid.DataSource = deptBinding;


            grid.Columns["DeptId"].Visible = false;
            grid.Columns["Mgr"].Visible = false;
            grid.Columns["Instructors"].Visible = false;
            //grid.Columns["Departments"].Visible = false;
            grid.Columns["Students"].Visible = false;


        //    public int DeptId { get; set; }
        //public string DeptName { get; set; }
        //public int? MgrId { get; set; }

        //public virtual Instructor Mgr { get; set; }
        //public virtual ICollection<Instructor> Instructors { get; set; }
        //public virtual ICollection<Student> Students { get; set; }


        //deptBinding.AddingNew += (sender, e) =>
        //{

        //};




    }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
