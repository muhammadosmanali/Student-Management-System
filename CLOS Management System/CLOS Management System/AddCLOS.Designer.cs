namespace CLOS_Management_System
{
    partial class AddCLOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCLOS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvClOData = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCLOName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCLOS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchCLO = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClOData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearchCLO);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.dgvClOData);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtCLOName);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblCLOS);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(37, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 256);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(17, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 70);
            this.panel2.TabIndex = 30;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(44, 94);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 15);
            this.lblID.TabIndex = 29;
            // 
            // dgvClOData
            // 
            this.dgvClOData.AllowUserToAddRows = false;
            this.dgvClOData.AllowUserToDeleteRows = false;
            this.dgvClOData.AllowUserToResizeColumns = false;
            this.dgvClOData.AllowUserToResizeRows = false;
            this.dgvClOData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClOData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClOData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClOData.Location = new System.Drawing.Point(393, 64);
            this.dgvClOData.Name = "dgvClOData";
            this.dgvClOData.Size = new System.Drawing.Size(406, 174);
            this.dgvClOData.TabIndex = 28;
            this.dgvClOData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClOData_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(304, 80);
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
            this.btnUpdate.Location = new System.Drawing.Point(255, 80);
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
            this.btnAdd.Location = new System.Drawing.Point(202, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 34);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCLOName
            // 
            this.txtCLOName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCLOName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCLOName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCLOName.Location = new System.Drawing.Point(139, 16);
            this.txtCLOName.Multiline = true;
            this.txtCLOName.Name = "txtCLOName";
            this.txtCLOName.Size = new System.Drawing.Size(199, 16);
            this.txtCLOName.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel7.Location = new System.Drawing.Point(139, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 9;
            // 
            // lblCLOS
            // 
            this.lblCLOS.AutoSize = true;
            this.lblCLOS.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCLOS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCLOS.Location = new System.Drawing.Point(60, 20);
            this.lblCLOS.Name = "lblCLOS";
            this.lblCLOS.Size = new System.Drawing.Size(71, 15);
            this.lblCLOS.TabIndex = 3;
            this.lblCLOS.Text = "CLO Name: ";
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
            // txtSearchCLO
            // 
            this.txtSearchCLO.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchCLO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchCLO.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtSearchCLO.Location = new System.Drawing.Point(546, 12);
            this.txtSearchCLO.Name = "txtSearchCLO";
            this.txtSearchCLO.Size = new System.Drawing.Size(199, 16);
            this.txtSearchCLO.TabIndex = 34;
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
            this.lblSearch.Location = new System.Drawing.Point(386, 17);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 15);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search CLO by Id or Name:";
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
            // AddCLOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F);
            this.Location = new System.Drawing.Point(0, 195);
            this.Name = "AddCLOS";
            this.Size = new System.Drawing.Size(891, 284);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClOData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCLOName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblCLOS;
        private System.Windows.Forms.DataGridView dgvClOData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchCLO;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnReload;
    }
}
