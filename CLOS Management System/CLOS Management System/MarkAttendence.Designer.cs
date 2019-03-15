namespace CLOS_Management_System
{
    partial class MarkAttendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkAttendence));
            this.pnaelAttendence = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAtt2 = new System.Windows.Forms.Label();
            this.lblAtt1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAttendence = new System.Windows.Forms.DataGridView();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnaelAttendence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // pnaelAttendence
            // 
            this.pnaelAttendence.BackColor = System.Drawing.Color.White;
            this.pnaelAttendence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnaelAttendence.Controls.Add(this.btnSubmit);
            this.pnaelAttendence.Controls.Add(this.lblAtt2);
            this.pnaelAttendence.Controls.Add(this.lblAtt1);
            this.pnaelAttendence.Controls.Add(this.label1);
            this.pnaelAttendence.Controls.Add(this.panel1);
            this.pnaelAttendence.Controls.Add(this.dgvAttendence);
            this.pnaelAttendence.Location = new System.Drawing.Point(33, 17);
            this.pnaelAttendence.Name = "pnaelAttendence";
            this.pnaelAttendence.Size = new System.Drawing.Size(823, 252);
            this.pnaelAttendence.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSubmit.Location = new System.Drawing.Point(672, 162);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(70, 76);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAtt2
            // 
            this.lblAtt2.AutoSize = true;
            this.lblAtt2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtt2.Location = new System.Drawing.Point(651, 73);
            this.lblAtt2.Name = "lblAtt2";
            this.lblAtt2.Size = new System.Drawing.Size(0, 23);
            this.lblAtt2.TabIndex = 3;
            // 
            // lblAtt1
            // 
            this.lblAtt1.AutoSize = true;
            this.lblAtt1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtt1.Location = new System.Drawing.Point(668, 41);
            this.lblAtt1.Name = "lblAtt1";
            this.lblAtt1.Size = new System.Drawing.Size(0, 23);
            this.lblAtt1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mark Attendence";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(3, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 197);
            this.panel1.TabIndex = 2;
            // 
            // dgvAttendence
            // 
            this.dgvAttendence.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAttendence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attendance});
            this.dgvAttendence.Location = new System.Drawing.Point(235, 3);
            this.dgvAttendence.Name = "dgvAttendence";
            this.dgvAttendence.Size = new System.Drawing.Size(391, 235);
            this.dgvAttendence.TabIndex = 1;
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            // 
            // MarkAttendence
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnaelAttendence);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(0, 195);
            this.Name = "MarkAttendence";
            this.Size = new System.Drawing.Size(891, 284);
            this.Load += new System.EventHandler(this.MarkAttendence_Load);
            this.pnaelAttendence.ResumeLayout(false);
            this.pnaelAttendence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnaelAttendence;
        private System.Windows.Forms.DataGridView dgvAttendence;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAtt2;
        private System.Windows.Forms.Label lblAtt1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
    }
}
