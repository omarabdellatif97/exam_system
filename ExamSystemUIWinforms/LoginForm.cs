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
    public partial class LoginForm : Form
    {
        public LoginForm()
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

            if(txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Not Valid Username Or Password",
                    "Not Valid Login Try",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var std = sys.ValidateStudent(txtName.Text, txtPassword.Text);

            if(std != null)
            {
                // load stduent system
                var stdSys = new StudentForm();
                //stdSys.FormClosed += (sender, e) => this.Close();
                stdSys.FormClosed += (sender, e) => this.Show();
                this.Hide();
                stdSys.Show();
                stdSys.SetStudent(std);
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
