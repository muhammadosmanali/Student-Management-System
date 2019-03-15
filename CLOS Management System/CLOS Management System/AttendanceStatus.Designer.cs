namespace CLOS_Management_System
{
    partial class AttendanceStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceStatus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelError = new System.Windows.Forms.Panel();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelError.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panelError);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchStudent);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.cmbRegNo);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(37, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 256);
            this.panel1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(581, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 39);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchStudent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSearchStudent.Location = new System.Drawing.Point(365, 20);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(199, 16);
            this.txtSearchStudent.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(365, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 3);
            this.panel8.TabIndex = 22;
            // 
            // cmbRegNo
            // 
            this.cmbRegNo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(365, 61);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(200, 23);
            this.cmbRegNo.TabIndex = 20;
            this.cmbRegNo.SelectedIndexChanged += new System.EventHandler(this.cmbRegNo_SelectedIndexChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(365, 84);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 3);
            this.panel9.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(218, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student Registration # :";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSearch.Location = new System.Drawing.Point(209, 24);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(150, 15);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search Student by Reg # :\r\n";
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label2);
            this.panel10.Location = new System.Drawing.Point(312, 134);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 26);
            this.panel10.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11F);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(22, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Attendance Percentage";
            // 
            // panelError
            // 
            this.panelError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelError.Controls.Add(this.lblPercentage);
            this.panelError.ForeColor = System.Drawing.Color.Red;
            this.panelError.Location = new System.Drawing.Point(312, 134);
            this.panelError.Name = "panelError";
            this.panelError.Size = new System.Drawing.Size(200, 84);
            this.panelError.TabIndex = 30;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPercentage.Location = new System.Drawing.Point(44, 43);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 18);
            this.lblPercentage.TabIndex = 0;
            // 
            // AttendanceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(0, 195);
            this.Name = "AttendanceStatus";
            this.Size = new System.Drawing.Size(891, 284);
            this.Load += new System.EventHandler(this.AttendanceStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelError.ResumeLayout(false);
            this.panelError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelError;
        private System.Windows.Forms.Label lblPercentage;
    }
}
