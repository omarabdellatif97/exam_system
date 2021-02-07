
namespace ExamSystemUIWinforms
{
    partial class InstructorPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.gridInsCourses = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.lblStdDept = new System.Windows.Forms.Label();
            this.lblStdEmail = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblStdId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInstructorPanel = new System.Windows.Forms.TabPage();
            this.btnInstructorManage = new System.Windows.Forms.Button();
            this.btnStudentManage = new System.Windows.Forms.Button();
            this.btnDeptManage = new System.Windows.Forms.Button();
            this.btnCoursesSystem = new System.Windows.Forms.Button();
            this.tabCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInsCourses)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabInstructorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.gridInsCourses);
            this.tabCourses.Controls.Add(this.panel1);
            this.tabCourses.Location = new System.Drawing.Point(4, 37);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCourses.Size = new System.Drawing.Size(900, 674);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Instructor Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // gridInsCourses
            // 
            this.gridInsCourses.AllowUserToAddRows = false;
            this.gridInsCourses.AllowUserToDeleteRows = false;
            this.gridInsCourses.AllowUserToOrderColumns = true;
            this.gridInsCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInsCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridInsCourses.Location = new System.Drawing.Point(5, 104);
            this.gridInsCourses.Name = "gridInsCourses";
            this.gridInsCourses.ReadOnly = true;
            this.gridInsCourses.RowHeadersWidth = 51;
            this.gridInsCourses.RowTemplate.Height = 29;
            this.gridInsCourses.Size = new System.Drawing.Size(890, 566);
            this.gridInsCourses.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(388, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Courses";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudent);
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabInstructorPanel);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(908, 715);
            this.tabControl.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.AutoScroll = true;
            this.tabStudent.Controls.Add(this.lblStdDept);
            this.tabStudent.Controls.Add(this.lblStdEmail);
            this.tabStudent.Controls.Add(this.lblStdName);
            this.tabStudent.Controls.Add(this.lblStdId);
            this.tabStudent.Controls.Add(this.label7);
            this.tabStudent.Controls.Add(this.label6);
            this.tabStudent.Controls.Add(this.label4);
            this.tabStudent.Controls.Add(this.label2);
            this.tabStudent.Controls.Add(this.label1);
            this.tabStudent.Location = new System.Drawing.Point(4, 37);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabStudent.Size = new System.Drawing.Size(900, 674);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "Instructor Info ";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // lblStdDept
            // 
            this.lblStdDept.AutoSize = true;
            this.lblStdDept.Location = new System.Drawing.Point(281, 221);
            this.lblStdDept.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdDept.Name = "lblStdDept";
            this.lblStdDept.Size = new System.Drawing.Size(117, 28);
            this.lblStdDept.TabIndex = 12;
            this.lblStdDept.Text = "Department";
            // 
            // lblStdEmail
            // 
            this.lblStdEmail.AutoSize = true;
            this.lblStdEmail.Location = new System.Drawing.Point(281, 169);
            this.lblStdEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdEmail.Name = "lblStdEmail";
            this.lblStdEmail.Size = new System.Drawing.Size(59, 28);
            this.lblStdEmail.TabIndex = 11;
            this.lblStdEmail.Text = "Email";
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Location = new System.Drawing.Point(281, 115);
            this.lblStdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(64, 28);
            this.lblStdName.TabIndex = 9;
            this.lblStdName.Text = "Name";
            // 
            // lblStdId
            // 
            this.lblStdId.AutoSize = true;
            this.lblStdId.Location = new System.Drawing.Point(281, 59);
            this.lblStdId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdId.Name = "lblStdId";
            this.lblStdId.Size = new System.Drawing.Size(38, 28);
            this.lblStdId.TabIndex = 7;
            this.lblStdId.Text = "Id: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 221);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Instructor Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Instructor Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Instructor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instructor Id: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Of Instructor";
            // 
            // tabInstructorPanel
            // 
            this.tabInstructorPanel.Controls.Add(this.btnInstructorManage);
            this.tabInstructorPanel.Controls.Add(this.btnStudentManage);
            this.tabInstructorPanel.Controls.Add(this.btnDeptManage);
            this.tabInstructorPanel.Controls.Add(this.btnCoursesSystem);
            this.tabInstructorPanel.Location = new System.Drawing.Point(4, 37);
            this.tabInstructorPanel.Name = "tabInstructorPanel";
            this.tabInstructorPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructorPanel.Size = new System.Drawing.Size(900, 674);
            this.tabInstructorPanel.TabIndex = 2;
            this.tabInstructorPanel.Text = "Instructor Control Panel";
            this.tabInstructorPanel.UseVisualStyleBackColor = true;
            // 
            // btnInstructorManage
            // 
            this.btnInstructorManage.Location = new System.Drawing.Point(32, 229);
            this.btnInstructorManage.Name = "btnInstructorManage";
            this.btnInstructorManage.Size = new System.Drawing.Size(837, 63);
            this.btnInstructorManage.TabIndex = 3;
            this.btnInstructorManage.Text = "Instructors";
            this.btnInstructorManage.UseVisualStyleBackColor = true;
            this.btnInstructorManage.Click += new System.EventHandler(this.btnInstructorManage_Click);
            // 
            // btnStudentManage
            // 
            this.btnStudentManage.Location = new System.Drawing.Point(32, 159);
            this.btnStudentManage.Name = "btnStudentManage";
            this.btnStudentManage.Size = new System.Drawing.Size(837, 63);
            this.btnStudentManage.TabIndex = 2;
            this.btnStudentManage.Text = "Students";
            this.btnStudentManage.UseVisualStyleBackColor = true;
            this.btnStudentManage.Click += new System.EventHandler(this.btnStudentManage_Click);
            // 
            // btnDeptManage
            // 
            this.btnDeptManage.Location = new System.Drawing.Point(32, 90);
            this.btnDeptManage.Name = "btnDeptManage";
            this.btnDeptManage.Size = new System.Drawing.Size(837, 63);
            this.btnDeptManage.TabIndex = 1;
            this.btnDeptManage.Text = "Departments";
            this.btnDeptManage.UseVisualStyleBackColor = true;
            this.btnDeptManage.Click += new System.EventHandler(this.btnDeptManage_Click);
            // 
            // btnCoursesSystem
            // 
            this.btnCoursesSystem.Location = new System.Drawing.Point(32, 21);
            this.btnCoursesSystem.Name = "btnCoursesSystem";
            this.btnCoursesSystem.Size = new System.Drawing.Size(837, 63);
            this.btnCoursesSystem.TabIndex = 0;
            this.btnCoursesSystem.Text = "Courses System";
            this.btnCoursesSystem.UseVisualStyleBackColor = true;
            this.btnCoursesSystem.Click += new System.EventHandler(this.btnCoursesSystem_Click);
            // 
            // InstructorPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 715);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InstructorPanelForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.tabCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInsCourses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.tabInstructorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.Label lblStdDept;
        private System.Windows.Forms.Label lblStdEmail;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabControlPanel;
        private System.Windows.Forms.TabPage tabInstructorPanel;
        private System.Windows.Forms.DataGridView gridInsCourses;
        private System.Windows.Forms.Button btnCoursesSystem;
        private System.Windows.Forms.Button btnInstructorManage;
        private System.Windows.Forms.Button btnStudentManage;
        private System.Windows.Forms.Button btnDeptManage;
    }
}