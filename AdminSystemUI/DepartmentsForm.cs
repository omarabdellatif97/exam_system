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

        DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
        BindingList<Instructor> stdList;
        BindingList<Department> deptList;

        BindingSource stdBinding;
        BindingSource deptBinding;
        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) =>
            {
                ctx.Dispose();
            };



            ctx.Departments.Load();
            ctx.Instructors.Load();
            deptList = ctx.Departments.Local.ToBindingList();
            stdList = ctx.Instructors.Local.ToBindingList();
            deptBinding = new BindingSource(deptList, "");
            stdBinding = new BindingSource(stdList, "");

            // we should add first datasource on grid
            grid.DataSource = deptBinding;


            //grid.Columns["DeptId"].Visible = false;
            grid.Columns["Mgr"].Visible = false;
            grid.Columns["MgrId"].Visible = false;
            grid.Columns["DeptId"].Visible = false;
            grid.Columns["Instructors"].Visible = false;
            //grid.Columns["Departments"].Visible = false;
            grid.Columns["Students"].Visible = false;


            //    public int DeptId { get; set; }
            //public string DeptName { get; set; }
            //public int? MgrId { get; set; }

            //public virtual Instructor Mgr { get; set; }
            //public virtual ICollection<Instructor> Instructors { get; set; }
            //public virtual ICollection<Student> Students { get; set; }


            grid.Columns.AddRange(DC);
            DC.DataSource = stdBinding;
            DC.HeaderText = "Manager";
            DC.DisplayMember = "InsName";
            DC.ValueMember = "InsId";
            DC.DataPropertyName = "MgrId";

            stdBinding.AddingNew += (sender, e) =>
            {
                e.NewObject = new Department()
                {
                    
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
