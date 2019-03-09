namespace CLOS_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHome = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRubrics = new System.Windows.Forms.Button();
            this.btnValuation = new System.Windows.Forms.Button();
            this.BtnCLOS = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.White;
            this.panelHome.Controls.Add(this.btnStudents);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.panel3);
            this.panelHome.Controls.Add(this.btnRubrics);
            this.panelHome.Controls.Add(this.btnValuation);
            this.panelHome.Controls.Add(this.BtnCLOS);
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Controls.Add(this.pbHome);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(76, 545);
            this.panelHome.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DBMS Lab";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Powerd by";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 127);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 58);
            this.panel3.TabIndex = 2;
            // 
            // btnRubrics
            // 
            this.btnRubrics.FlatAppearance.BorderSize = 0;
            this.btnRubrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRubrics.Image = ((System.Drawing.Image)(resources.GetObject("btnRubrics.Image")));
            this.btnRubrics.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRubrics.Location = new System.Drawing.Point(3, 385);
            this.btnRubrics.Name = "btnRubrics";
            this.btnRubrics.Size = new System.Drawing.Size(70, 58);
            this.btnRubrics.TabIndex = 2;
            this.btnRubrics.Text = " Rubrics";
            this.btnRubrics.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRubrics.UseVisualStyleBackColor = true;
            this.btnRubrics.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnValuation
            // 
            this.btnValuation.FlatAppearance.BorderSize = 0;
            this.btnValuation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValuation.Image = ((System.Drawing.Image)(resources.GetObject("btnValuation.Image")));
            this.btnValuation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnValuation.Location = new System.Drawing.Point(3, 320);
            this.btnValuation.Name = "btnValuation";
            this.btnValuation.Size = new System.Drawing.Size(70, 58);
            this.btnValuation.TabIndex = 2;
            this.btnValuation.Text = "Valuation";
            this.btnValuation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValuation.UseVisualStyleBackColor = true;
            this.btnValuation.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BtnCLOS
            // 
            this.BtnCLOS.FlatAppearance.BorderSize = 0;
            this.BtnCLOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCLOS.Image = ((System.Drawing.Image)(resources.GetObject("BtnCLOS.Image")));
            this.BtnCLOS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCLOS.Location = new System.Drawing.Point(3, 255);
            this.BtnCLOS.Name = "BtnCLOS";
            this.BtnCLOS.Size = new System.Drawing.Size(70, 58);
            this.BtnCLOS.TabIndex = 2;
            this.BtnCLOS.Text = " CLOS";
            this.BtnCLOS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCLOS.UseVisualStyleBackColor = true;
            this.BtnCLOS.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(8, 127);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(65, 58);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "  Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pbHome
            // 
            this.pbHome.Image = ((System.Drawing.Image)(resources.GetObject("pbHome.Image")));
            this.pbHome.Location = new System.Drawing.Point(8, 5);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(62, 81);
            this.pbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHome.TabIndex = 2;
            this.pbHome.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(831, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelExit
            // 
            this.panelExit.Controls.Add(this.btnMinimize);
            this.panelExit.Controls.Add(this.btnExit);
            this.panelExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExit.Location = new System.Drawing.Point(76, 0);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(891, 49);
            this.panelExit.TabIndex = 3;
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(777, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(48, 41);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudents.Location = new System.Drawing.Point(3, 191);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(70, 58);
            this.btnStudents.TabIndex = 5;
            this.btnStudents.Text = "  Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(967, 545);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelHome);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.panelExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button BtnCLOS;
        private System.Windows.Forms.Button btnValuation;
        private System.Windows.Forms.Button btnRubrics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStudents;
    }
}

