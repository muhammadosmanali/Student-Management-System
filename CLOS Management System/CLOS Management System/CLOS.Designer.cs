namespace CLOS_Management_System
{
    partial class CLOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLOS));
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.btnRubricsLevel = new System.Windows.Forms.Button();
            this.btnManageRubrics = new System.Windows.Forms.Button();
            this.btnLookUpStudents = new System.Windows.Forms.Button();
            this.btnManageCLOS = new System.Windows.Forms.Button();
            this.panelAddStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddStudent
            // 
            this.panelAddStudent.BackColor = System.Drawing.Color.White;
            this.panelAddStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddStudent.Controls.Add(this.btnRubricsLevel);
            this.panelAddStudent.Controls.Add(this.btnManageRubrics);
            this.panelAddStudent.Controls.Add(this.btnLookUpStudents);
            this.panelAddStudent.Controls.Add(this.btnManageCLOS);
            this.panelAddStudent.Location = new System.Drawing.Point(14, 16);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(861, 158);
            this.panelAddStudent.TabIndex = 1;
            // 
            // btnRubricsLevel
            // 
            this.btnRubricsLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnRubricsLevel.FlatAppearance.BorderSize = 0;
            this.btnRubricsLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubricsLevel.Image = ((System.Drawing.Image)(resources.GetObject("btnRubricsLevel.Image")));
            this.btnRubricsLevel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRubricsLevel.Location = new System.Drawing.Point(437, 34);
            this.btnRubricsLevel.Name = "btnRubricsLevel";
            this.btnRubricsLevel.Size = new System.Drawing.Size(129, 87);
            this.btnRubricsLevel.TabIndex = 6;
            this.btnRubricsLevel.Text = "Manage Rubric Levels";
            this.btnRubricsLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRubricsLevel.UseVisualStyleBackColor = false;
            // 
            // btnManageRubrics
            // 
            this.btnManageRubrics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnManageRubrics.FlatAppearance.BorderSize = 0;
            this.btnManageRubrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRubrics.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRubrics.Image")));
            this.btnManageRubrics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageRubrics.Location = new System.Drawing.Point(261, 34);
            this.btnManageRubrics.Name = "btnManageRubrics";
            this.btnManageRubrics.Size = new System.Drawing.Size(129, 87);
            this.btnManageRubrics.TabIndex = 6;
            this.btnManageRubrics.Text = "Manage Rubrics";
            this.btnManageRubrics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageRubrics.UseVisualStyleBackColor = false;
            this.btnManageRubrics.Click += new System.EventHandler(this.btnManageRubrics_Click);
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
            // btnManageCLOS
            // 
            this.btnManageCLOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.btnManageCLOS.FlatAppearance.BorderSize = 0;
            this.btnManageCLOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCLOS.Image = ((System.Drawing.Image)(resources.GetObject("btnManageCLOS.Image")));
            this.btnManageCLOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnManageCLOS.Location = new System.Drawing.Point(91, 34);
            this.btnManageCLOS.Name = "btnManageCLOS";
            this.btnManageCLOS.Size = new System.Drawing.Size(129, 87);
            this.btnManageCLOS.TabIndex = 6;
            this.btnManageCLOS.Text = "Manage CLOS";
            this.btnManageCLOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManageCLOS.UseVisualStyleBackColor = false;
            this.btnManageCLOS.Click += new System.EventHandler(this.btnManageCLOS_Click);
            // 
            // CLOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAddStudent);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(76, 43);
            this.Name = "CLOS";
            this.Size = new System.Drawing.Size(891, 496);
            this.panelAddStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddStudent;
        private System.Windows.Forms.Button btnRubricsLevel;
        private System.Windows.Forms.Button btnManageRubrics;
        private System.Windows.Forms.Button btnLookUpStudents;
        private System.Windows.Forms.Button btnManageCLOS;
    }
}
