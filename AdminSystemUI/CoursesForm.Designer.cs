
namespace AdminSystemUI
{
    partial class CoursesForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveCourses = new System.Windows.Forms.Button();
            this.gridAllCourses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStdState = new System.Windows.Forms.Label();
            this.btnCheckStdCrs = new System.Windows.Forms.Button();
            this.btnRemoveStdCrs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStd = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInsState = new System.Windows.Forms.Label();
            this.btnCheckAssign = new System.Windows.Forms.Button();
            this.btnRemoveInsCrs = new System.Windows.Forms.Button();
            this.btnAssignInstructor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInsCourses = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInstructor = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllCourses)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.gridAllCourses);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(901, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Courses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveCourses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 486);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 76);
            this.panel1.TabIndex = 1;
            // 
            // btnSaveCourses
            // 
            this.btnSaveCourses.Location = new System.Drawing.Point(314, 16);
            this.btnSaveCourses.Name = "btnSaveCourses";
            this.btnSaveCourses.Size = new System.Drawing.Size(273, 45);
            this.btnSaveCourses.TabIndex = 0;
            this.btnSaveCourses.Text = "Save Courses";
            this.btnSaveCourses.UseVisualStyleBackColor = true;
            this.btnSaveCourses.Click += new System.EventHandler(this.btnSaveCourses_Click);
            // 
            // gridAllCourses
            // 
            this.gridAllCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAllCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllCourses.Location = new System.Drawing.Point(3, 3);
            this.gridAllCourses.Name = "gridAllCourses";
            this.gridAllCourses.RowHeadersWidth = 51;
            this.gridAllCourses.RowTemplate.Height = 29;
            this.gridAllCourses.Size = new System.Drawing.Size(895, 559);
            this.gridAllCourses.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(901, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStdState);
            this.panel2.Controls.Add(this.btnCheckStdCrs);
            this.panel2.Controls.Add(this.btnRemoveStdCrs);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbCourse);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbStd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 559);
            this.panel2.TabIndex = 1;
            // 
            // lblStdState
            // 
            this.lblStdState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStdState.AutoSize = true;
            this.lblStdState.Location = new System.Drawing.Point(409, 281);
            this.lblStdState.Name = "lblStdState";
            this.lblStdState.Size = new System.Drawing.Size(0, 31);
            this.lblStdState.TabIndex = 9;
            // 
            // btnCheckStdCrs
            // 
            this.btnCheckStdCrs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckStdCrs.Location = new System.Drawing.Point(94, 161);
            this.btnCheckStdCrs.Name = "btnCheckStdCrs";
            this.btnCheckStdCrs.Size = new System.Drawing.Size(237, 75);
            this.btnCheckStdCrs.TabIndex = 8;
            this.btnCheckStdCrs.Text = "Check If Assigned";
            this.btnCheckStdCrs.UseVisualStyleBackColor = true;
            this.btnCheckStdCrs.Click += new System.EventHandler(this.btnCheckStdCrs_Click);
            // 
            // btnRemoveStdCrs
            // 
            this.btnRemoveStdCrs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveStdCrs.Location = new System.Drawing.Point(580, 161);
            this.btnRemoveStdCrs.Name = "btnRemoveStdCrs";
            this.btnRemoveStdCrs.Size = new System.Drawing.Size(237, 75);
            this.btnRemoveStdCrs.TabIndex = 7;
            this.btnRemoveStdCrs.Text = "Remove Instrucor";
            this.btnRemoveStdCrs.UseVisualStyleBackColor = true;
            this.btnRemoveStdCrs.Click += new System.EventHandler(this.btnRemoveStdCrs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Location = new System.Drawing.Point(337, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 75);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Assign Student";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Course";
            // 
            // cmbCourse
            // 
            this.cmbCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(189, 98);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(623, 39);
            this.cmbCourse.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Student";
            // 
            // cmbStd
            // 
            this.cmbStd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStd.FormattingEnabled = true;
            this.cmbStd.Location = new System.Drawing.Point(189, 41);
            this.cmbStd.Name = "cmbStd";
            this.cmbStd.Size = new System.Drawing.Size(623, 39);
            this.cmbStd.TabIndex = 0;
            this.cmbStd.SelectedIndexChanged += new System.EventHandler(this.cmbStd_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(901, 565);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register Instructor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblInsState);
            this.panel3.Controls.Add(this.btnCheckAssign);
            this.panel3.Controls.Add(this.btnRemoveInsCrs);
            this.panel3.Controls.Add(this.btnAssignInstructor);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cmbInsCourses);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbInstructor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 559);
            this.panel3.TabIndex = 2;
            // 
            // lblInsState
            // 
            this.lblInsState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInsState.AutoSize = true;
            this.lblInsState.Location = new System.Drawing.Point(396, 253);
            this.lblInsState.Name = "lblInsState";
            this.lblInsState.Size = new System.Drawing.Size(0, 31);
            this.lblInsState.TabIndex = 7;
            // 
            // btnCheckAssign
            // 
            this.btnCheckAssign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckAssign.Location = new System.Drawing.Point(114, 151);
            this.btnCheckAssign.Name = "btnCheckAssign";
            this.btnCheckAssign.Size = new System.Drawing.Size(237, 75);
            this.btnCheckAssign.TabIndex = 6;
            this.btnCheckAssign.Text = "Check If Assigned";
            this.btnCheckAssign.UseVisualStyleBackColor = true;
            this.btnCheckAssign.Click += new System.EventHandler(this.btnCheckAssign_Click);
            // 
            // btnRemoveInsCrs
            // 
            this.btnRemoveInsCrs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveInsCrs.Location = new System.Drawing.Point(357, 151);
            this.btnRemoveInsCrs.Name = "btnRemoveInsCrs";
            this.btnRemoveInsCrs.Size = new System.Drawing.Size(237, 75);
            this.btnRemoveInsCrs.TabIndex = 5;
            this.btnRemoveInsCrs.Text = "Remove Instrucor";
            this.btnRemoveInsCrs.UseVisualStyleBackColor = true;
            this.btnRemoveInsCrs.Click += new System.EventHandler(this.btnInstructorCrsRemove);
            // 
            // btnAssignInstructor
            // 
            this.btnAssignInstructor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAssignInstructor.Location = new System.Drawing.Point(600, 151);
            this.btnAssignInstructor.Name = "btnAssignInstructor";
            this.btnAssignInstructor.Size = new System.Drawing.Size(237, 75);
            this.btnAssignInstructor.TabIndex = 4;
            this.btnAssignInstructor.Text = "Add Instructor";
            this.btnAssignInstructor.UseVisualStyleBackColor = true;
            this.btnAssignInstructor.Click += new System.EventHandler(this.btnAssignInstructor_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Course";
            // 
            // cmbInsCourses
            // 
            this.cmbInsCourses.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbInsCourses.FormattingEnabled = true;
            this.cmbInsCourses.Location = new System.Drawing.Point(214, 90);
            this.cmbInsCourses.Name = "cmbInsCourses";
            this.cmbInsCourses.Size = new System.Drawing.Size(623, 39);
            this.cmbInsCourses.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Instructor";
            // 
            // cmbInstructor
            // 
            this.cmbInstructor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbInstructor.FormattingEnabled = true;
            this.cmbInstructor.Location = new System.Drawing.Point(214, 33);
            this.cmbInstructor.Name = "cmbInstructor";
            this.cmbInstructor.Size = new System.Drawing.Size(623, 39);
            this.cmbInstructor.TabIndex = 0;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 609);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "CoursesForm";
            this.Text = "CoursesForm";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllCourses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridAllCourses;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveCourses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAssignInstructor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbInsCourses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbInstructor;
        private System.Windows.Forms.Label lblInsState;
        private System.Windows.Forms.Button btnCheckAssign;
        private System.Windows.Forms.Button btnRemoveInsCrs;
        private System.Windows.Forms.Label lblStdState;
        private System.Windows.Forms.Button btnCheckStdCrs;
        private System.Windows.Forms.Button btnRemoveStdCrs;
    }
}