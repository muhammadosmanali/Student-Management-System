namespace CLOS_Management_System
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.btnAttendenceStatus = new System.Windows.Forms.Button();
            this.btnMarkAttendence = new System.Windows.Forms.Button();
            this.btnLookUpStudents = new System.Windows.Forms.Button();
            this.btnAddStudents = new System.Windows.Forms.Button();
            this.panelAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.BackColor = System.Drawing.Color.White;
            this.panelAddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddStudent.Controls.Add(this.btnAttendenceStatus);
            this.panelAddStudent.Controls.Add(this.btnMarkAttendence);
            this.panelAddStudent.Controls.Add(this.btnLookUpStudents);
            this.panelAddStudent.Controls.Add(this.btnAddStudents);
            this.panelAddStudent.Location = new System.Drawing.Point(14, 16);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(861, 158);
            this.panelAddStudent.TabIndex = 0;
            // 
            // btnAttendenceStatus
            // 
            this.btnAttendenceStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnAttendenceStatus.FlatAppearance.BorderSize = 0;
            this.btnAttendenceStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendenceStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendenceStatus.Image")));
            this.btnAttendenceStatus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAttendenceStatus.Location = new System.Drawing.Point(437, 34);
            this.btnAttendenceStatus.Name = "btnAttendenceStatus";
            this.btnAttendenceStatus.Size = new System.Drawing.Size(129, 87);
            this.btnAttendenceStatus.TabIndex = 6;
            this.btnAttendenceStatus.Text = "Student Attendence Status";
            this.btnAttendenceStatus.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAttendenceStatus.UseVisualStyleBackColor = false;
            this.btnAttendenceStatus.Click += new System.EventHandler(this.btnAttendenceStatus_Click);
            // 
            // btnMarkAttendence
            // 
            this.btnMarkAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnMarkAttendence.FlatAppearance.BorderSize = 0;
            this.btnMarkAttendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAttendence.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkAttendence.Image")));
            this.btnMarkAttendence.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarkAttendence.Location = new System.Drawing.Point(261, 34);
            this.btnMarkAttendence.Name = "btnMarkAttendence";
            this.btnMarkAttendence.Size = new System.Drawing.Size(129, 87);
            this.btnMarkAttendence.TabIndex = 6;
            this.btnMarkAttendence.Text = "Mark Attendence";
            this.btnMarkAttendence.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarkAttendence.UseVisualStyleBackColor = false;
            this.btnMarkAttendence.Click += new System.EventHandler(this.btnMarkAttendence_Click);
            // 
            // btnLookUpStudents
            // 
            this.btnLookUpStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnLookUpStudents.FlatAppearance.BorderSize = 0;
            this.btnLookUpStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUpStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnLookUpStudents.Image")));
            this.btnLookUpStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLookUpStudents.Location = new System.Drawing.Point(611, 34);
            this.btnLookUpStudents.Name = "btnLookUpStudents";
            this.btnLookUpStudents.Size = new System.Drawing.Size(129, 87);
            this.btnLookUpStudents.TabIndex = 6;
            this.btnLookUpStudents.Text = "Student Detials";
            this.btnLookUpStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLookUpStudents.UseVisualStyleBackColor = false;
            // 
            // btnAddStudents
            // 
            this.btnAddStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnAddStudents.FlatAppearance.BorderSize = 0;
            this.btnAddStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudents.Image")));
            this.btnAddStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddStudents.Location = new System.Drawing.Point(91, 34);
            this.btnAddStudents.Name = "btnAddStudents";
            this.btnAddStudents.Size = new System.Drawing.Size(129, 87);
            this.btnAddStudents.TabIndex = 6;
            this.btnAddStudents.Text = "Manage Student";
            this.btnAddStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddStudents.UseVisualStyleBackColor = false;
            this.btnAddStudents.Click += new System.EventHandler(this.btnAddStudents_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddStudent);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(76, 43);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(891, 496);
            this.panelAddStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddStudent;
        private System.Windows.Forms.Button btnAddStudents;
        private System.Windows.Forms.Button btnAttendenceStatus;
        private System.Windows.Forms.Button btnMarkAttendence;
        private System.Windows.Forms.Button btnLookUpStudents;
    }
}
