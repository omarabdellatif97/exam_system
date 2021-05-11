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
    public partial class InstructorsForm : Form
    {
        public InstructorsForm()
        {
            InitializeComponent();
        }


        ExamContext ctx = new ExamContext();

        DataGridViewComboBoxColumn DC = new DataGridViewComboBoxColumn();
        BindingList<Instructor> stdList;
        BindingList<Department> deptList;

        BindingSource stdBinding;
        BindingSource deptBinding;


        private void InstructorsForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += (sender, e) =>
            {
                ctx.Dispose();
            };



            ctx.Instructors.Load();
            ctx.Departments.Load();
            stdList = ctx.Instructors.Local.ToBindingList();
            deptList = ctx.Departments.Local.ToBindingList();

            stdBinding = new BindingSource(stdList, "");
            deptBinding = new BindingSource(deptList, "");






            //public int InsId { get; set; }
            //public string InsName { get; set; }
            //public string InsEmail { get; set; }
            //public string InsHashedPwd { get; set; }
            //public int DeptId { get; set; }

            //public virtual Department Dept { get; set; }
            //public virtual ICollection<Department> Departments { get; set; }
            //public virtual ICollection<InsCr> InsCrs { get; set; }


            // we should add first datasource on grid
            grid.DataSource = stdBinding;


            grid.Columns["InsId"].Visible = false;
            grid.Columns["InsHashedPwd"].Visible = false;
            grid.Columns["Dept"].Visible = false;
            //grid.Columns["Departments"].Visible = false;
            grid.Columns["InsCrs"].Visible = false;


            grid.Columns.AddRange(DC);
            DC.DataSource = deptBinding;
            DC.HeaderText = "Departments";
            DC.DisplayMember = "DeptName";
            DC.ValueMember = "DeptId";
            DC.DataPropertyName = "DeptId";

            stdBinding.AddingNew += (sender, e) =>
             {
                 e.NewObject = new Instructor()
                 {
                     DeptId = deptList.FirstOrDefault().DeptId,
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
