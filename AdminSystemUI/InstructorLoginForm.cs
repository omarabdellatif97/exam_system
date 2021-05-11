using ExamSystem.Systems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystemUIWinforms
{
    public partial class InstructorLoginForm : Form
    {
        public InstructorLoginForm()
        {
            InitializeComponent();
        }

        private LoginSystem sys;


        private void LoginForm_Load(object sender, EventArgs e)
        {
            sys = new LoginSystem();

            this.FormClosed += LoginForm_FormClosed;

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // to close data base connection here;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(txtName.Text == "" ||  txtPassword.Text == "")
            {
                MessageBox.Show("Not Valid Username Or Password",
                    "Not Valid Login Try",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var std = sys.ValidateInstructor(txtName.Text, txtPassword.Text);

            if(std != null)
            {
                //load stduent system
               var insSys = new InstructorPanelForm();
                //insSys.FormClosed += (sender, e) => this.Close();
                insSys.FormClosed += (sender, e) => this.Show();
                this.Hide();
                insSys.Show();
                insSys.SetInstructor(std);
            }
            else
            {
                MessageBox.Show("Not Valid Username Or Password",
                    "Not Valid Login Try", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
