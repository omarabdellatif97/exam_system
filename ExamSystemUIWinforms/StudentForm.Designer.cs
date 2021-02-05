
namespace ExamSystemUIWinforms
{
    partial class StudentForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.lblStdDept = new System.Windows.Forms.Label();
            this.lblStdEmail = new System.Windows.Forms.Label();
            this.lblStdBirth = new System.Windows.Forms.Label();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblStdSSN = new System.Windows.Forms.Label();
            this.lblStdId = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCourses = new System.Windows.Forms.TabPage();
            this.flowPanelCourses = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.lblCrsId = new System.Windows.Forms.Label();
            this.lblCrsStartDate = new System.Windows.Forms.Label();
            this.lblCrsStatus = new System.Windows.Forms.Label();
            this.lblCrsName = new System.Windows.Forms.Label();
            this.lblCrsEndDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabExams = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabCourses.SuspendLayout();
            this.flowPanelCourses.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStudent);
            this.tabControl.Controls.Add(this.tabCourses);
            this.tabControl.Controls.Add(this.tabExams);
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
            this.tabStudent.Controls.Add(this.lblStdBirth);
            this.tabStudent.Controls.Add(this.lblStdName);
            this.tabStudent.Controls.Add(this.lblStdSSN);
            this.tabStudent.Controls.Add(this.lblStdId);
            this.tabStudent.Controls.Add(this.label7);
            this.tabStudent.Controls.Add(this.label6);
            this.tabStudent.Controls.Add(this.label5);
            this.tabStudent.Controls.Add(this.label4);
            this.tabStudent.Controls.Add(this.label3);
            this.tabStudent.Controls.Add(this.label2);
            this.tabStudent.Controls.Add(this.label1);
            this.tabStudent.Location = new System.Drawing.Point(4, 37);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabStudent.Size = new System.Drawing.Size(900, 674);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = " Student Info ";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // lblStdDept
            // 
            this.lblStdDept.AutoSize = true;
            this.lblStdDept.Location = new System.Drawing.Point(388, 277);
            this.lblStdDept.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdDept.Name = "lblStdDept";
            this.lblStdDept.Size = new System.Drawing.Size(190, 28);
            this.lblStdDept.TabIndex = 12;
            this.lblStdDept.Text = "Student Department";
            // 
            // lblStdEmail
            // 
            this.lblStdEmail.AutoSize = true;
            this.lblStdEmail.Location = new System.Drawing.Point(388, 238);
            this.lblStdEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdEmail.Name = "lblStdEmail";
            this.lblStdEmail.Size = new System.Drawing.Size(132, 28);
            this.lblStdEmail.TabIndex = 11;
            this.lblStdEmail.Text = "Student Email";
            // 
            // lblStdBirth
            // 
            this.lblStdBirth.AutoSize = true;
            this.lblStdBirth.Location = new System.Drawing.Point(388, 193);
            this.lblStdBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdBirth.Name = "lblStdBirth";
            this.lblStdBirth.Size = new System.Drawing.Size(126, 28);
            this.lblStdBirth.TabIndex = 10;
            this.lblStdBirth.Text = "Student Birth";
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Location = new System.Drawing.Point(388, 148);
            this.lblStdName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(137, 28);
            this.lblStdName.TabIndex = 9;
            this.lblStdName.Text = "Student Name";
            // 
            // lblStdSSN
            // 
            this.lblStdSSN.AutoSize = true;
            this.lblStdSSN.Location = new System.Drawing.Point(388, 104);
            this.lblStdSSN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdSSN.Name = "lblStdSSN";
            this.lblStdSSN.Size = new System.Drawing.Size(122, 28);
            this.lblStdSSN.TabIndex = 8;
            this.lblStdSSN.Text = "Student SSN";
            // 
            // lblStdId
            // 
            this.lblStdId.AutoSize = true;
            this.lblStdId.Location = new System.Drawing.Point(388, 59);
            this.lblStdId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStdId.Name = "lblStdId";
            this.lblStdId.Size = new System.Drawing.Size(111, 28);
            this.lblStdId.TabIndex = 7;
            this.lblStdId.Text = "Student Id: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Student Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Id: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Of Student";
            // 
            // tabCourses
            // 
            this.tabCourses.Controls.Add(this.flowPanelCourses);
            this.tabCourses.Controls.Add(this.panel1);
            this.tabCourses.Location = new System.Drawing.Point(4, 37);
            this.tabCourses.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCourses.Name = "tabCourses";
            this.tabCourses.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabCourses.Size = new System.Drawing.Size(900, 674);
            this.tabCourses.TabIndex = 1;
            this.tabCourses.Text = "Student Courses";
            this.tabCourses.UseVisualStyleBackColor = true;
            // 
            // flowPanelCourses
            // 
            this.flowPanelCourses.AutoScroll = true;
            this.flowPanelCourses.Controls.Add(this.tableLayoutPanel1);
            this.flowPanelCourses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelCourses.Location = new System.Drawing.Point(5, 104);
            this.flowPanelCourses.Name = "flowPanelCourses";
            this.flowPanelCourses.Size = new System.Drawing.Size(890, 566);
            this.flowPanelCourses.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnStartExam, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCrsId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCrsStartDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCrsStatus, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCrsName, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCrsEndDate, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 135);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 51);
            this.label12.TabIndex = 3;
            this.label12.Text = "YourStatus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Start Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(3, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID: ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label11, 4);
            this.label11.Location = new System.Drawing.Point(201, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 28);
            this.label11.TabIndex = 2;
            this.label11.Text = "C# Course";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 28);
            this.label16.TabIndex = 7;
            this.label16.Text = "Name: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(261, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 28);
            this.label17.TabIndex = 8;
            this.label17.Text = "End Date";
            // 
            // btnStartExam
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnStartExam, 2);
            this.btnStartExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartExam.Location = new System.Drawing.Point(261, 87);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(239, 45);
            this.btnStartExam.TabIndex = 9;
            this.btnStartExam.Text = "Start Exam";
            this.btnStartExam.UseVisualStyleBackColor = true;
            // 
            // lblCrsId
            // 
            this.lblCrsId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCrsId.AutoSize = true;
            this.lblCrsId.Location = new System.Drawing.Point(153, 28);
            this.lblCrsId.Name = "lblCrsId";
            this.lblCrsId.Size = new System.Drawing.Size(61, 28);
            this.lblCrsId.TabIndex = 10;
            this.lblCrsId.Text = "TEMP";
            // 
            // lblCrsStartDate
            // 
            this.lblCrsStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCrsStartDate.AutoSize = true;
            this.lblCrsStartDate.Location = new System.Drawing.Point(153, 56);
            this.lblCrsStartDate.Name = "lblCrsStartDate";
            this.lblCrsStartDate.Size = new System.Drawing.Size(61, 28);
            this.lblCrsStartDate.TabIndex = 11;
            this.lblCrsStartDate.Text = "TEMP";
            // 
            // lblCrsStatus
            // 
            this.lblCrsStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCrsStatus.AutoSize = true;
            this.lblCrsStatus.Location = new System.Drawing.Point(153, 95);
            this.lblCrsStatus.Name = "lblCrsStatus";
            this.lblCrsStatus.Size = new System.Drawing.Size(61, 28);
            this.lblCrsStatus.TabIndex = 12;
            this.lblCrsStatus.Text = "TEMP";
            // 
            // lblCrsName
            // 
            this.lblCrsName.AutoSize = true;
            this.lblCrsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCrsName.Location = new System.Drawing.Point(358, 28);
            this.lblCrsName.Name = "lblCrsName";
            this.lblCrsName.Size = new System.Drawing.Size(142, 28);
            this.lblCrsName.TabIndex = 13;
            this.lblCrsName.Text = "TEMP";
            // 
            // lblCrsEndDate
            // 
            this.lblCrsEndDate.AutoSize = true;
            this.lblCrsEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCrsEndDate.Location = new System.Drawing.Point(358, 56);
            this.lblCrsEndDate.Name = "lblCrsEndDate";
            this.lblCrsEndDate.Size = new System.Drawing.Size(142, 28);
            this.lblCrsEndDate.TabIndex = 14;
            this.lblCrsEndDate.Text = "TEMP";
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
            this.label8.Location = new System.Drawing.Point(333, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 41);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student Courses";
            // 
            // tabExams
            // 
            this.tabExams.Location = new System.Drawing.Point(4, 37);
            this.tabExams.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabExams.Name = "tabExams";
            this.tabExams.Size = new System.Drawing.Size(900, 674);
            this.tabExams.TabIndex = 2;
            this.tabExams.Text = "Student Exams";
            this.tabExams.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 715);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.tabCourses.ResumeLayout(false);
            this.flowPanelCourses.ResumeLayout(false);
            this.flowPanelCourses.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabCourses;
        private System.Windows.Forms.TabPage tabExams;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStdDept;
        private System.Windows.Forms.Label lblStdEmail;
        private System.Windows.Forms.Label lblStdBirth;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblStdSSN;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCourses;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Label lblCrsId;
        private System.Windows.Forms.Label lblCrsStartDate;
        private System.Windows.Forms.Label lblCrsStatus;
        private System.Windows.Forms.Label lblCrsName;
        private System.Windows.Forms.Label lblCrsEndDate;
    }
}