namespace CLOS_Management_System
{
    partial class AddRubrics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRubrics));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchRubric = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvRubricData = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtRubricDetail = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRubric = new System.Windows.Forms.Label();
            this.cmbCLO = new System.Windows.Forms.ComboBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubricData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbCLO);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchRubric);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.dgvRubricData);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtRubricDetail);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblRubric);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(37, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 256);
            this.panel1.TabIndex = 4;
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Black;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReload.Location = new System.Drawing.Point(349, 204);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(38, 34);
            this.btnReload.TabIndex = 36;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(762, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 39);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchRubric
            // 
            this.txtSearchRubric.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchRubric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchRubric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSearchRubric.Location = new System.Drawing.Point(546, 12);
            this.txtSearchRubric.Name = "txtSearchRubric";
            this.txtSearchRubric.Size = new System.Drawing.Size(199, 16);
            this.txtSearchRubric.TabIndex = 34;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel8.Location = new System.Drawing.Point(546, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 3);
            this.panel8.TabIndex = 33;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSearch.Location = new System.Drawing.Point(407, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(133, 15);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search Rubrics by CLO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select from Table to Update or Delete";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(20, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 44);
            this.panel2.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(47, 166);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 15);
            this.lblID.TabIndex = 29;
            // 
            // dgvRubricData
            // 
            this.dgvRubricData.AllowUserToAddRows = false;
            this.dgvRubricData.AllowUserToDeleteRows = false;
            this.dgvRubricData.AllowUserToResizeColumns = false;
            this.dgvRubricData.AllowUserToResizeRows = false;
            this.dgvRubricData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRubricData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRubricData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubricData.Location = new System.Drawing.Point(393, 64);
            this.dgvRubricData.Name = "dgvRubricData";
            this.dgvRubricData.Size = new System.Drawing.Size(406, 174);
            this.dgvRubricData.TabIndex = 28;
            this.dgvRubricData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubricData_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(311, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(262, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(36, 34);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(209, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 34);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtRubricDetail
            // 
            this.txtRubricDetail.BackColor = System.Drawing.SystemColors.Window;
            this.txtRubricDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRubricDetail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRubricDetail.Location = new System.Drawing.Point(146, 60);
            this.txtRubricDetail.Multiline = true;
            this.txtRubricDetail.Name = "txtRubricDetail";
            this.txtRubricDetail.Size = new System.Drawing.Size(199, 48);
            this.txtRubricDetail.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(146, 108);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 9;
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRubric.Location = new System.Drawing.Point(59, 64);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(81, 15);
            this.lblRubric.TabIndex = 3;
            this.lblRubric.Text = "Rubric Detail:";
            // 
            // cmbCLO
            // 
            this.cmbCLO.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbCLO.FormattingEnabled = true;
            this.cmbCLO.Location = new System.Drawing.Point(148, 20);
            this.cmbCLO.Name = "cmbCLO";
            this.cmbCLO.Size = new System.Drawing.Size(200, 23);
            this.cmbCLO.TabIndex = 39;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel9.Location = new System.Drawing.Point(148, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 3);
            this.panel9.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(59, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "CLO Name:";
            // 
            // AddRubrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(0, 195);
            this.Name = "AddRubrics";
            this.Size = new System.Drawing.Size(891, 284);
            this.Load += new System.EventHandler(this.AddRubrics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubricData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchRubric;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvRubricData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtRubricDetail;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblRubric;
        private System.Windows.Forms.ComboBox cmbCLO;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
    }
}
