using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CLOS_Management_System
{
    public partial class MarkAttendence : UserControl
    {
        public MarkAttendence()
        {
            InitializeComponent();
        }

        private void MarkAttendence_Load(object sender, EventArgs e)
        {
            mark_Attendence();
            disable_Button();
            dgv_Design();
            DataGridViewCheckBoxColumn dgvcmb = new DataGridViewCheckBoxColumn();
            dgvcmb.HeaderText = "Attendence";
            dgvcmb.Name = "cmbAttendence";
            dgvAttendence.Columns.Add(dgvcmb);
        }

        private void mark_Attendence()
        {
            string query = "Select FirstName + ' ' + LastName As Name, " +
                "RegistrationNumber As [Registration Number]" +
                "from Student " +
                "Order by RegistrationNumber";

            SqlDataAdapter sqladp = new SqlDataAdapter(query, DatabaseConnection.getInstance().getConnection());
            DataTable tbl = new DataTable();
            sqladp.Fill(tbl);
            dgvAttendence.DataSource = tbl;
            dgvAttendence.Columns["Name"].ReadOnly = true;
            dgvAttendence.Columns["Registration Number"].ReadOnly = true;

        }

        private void dgv_Design()
        {
            dgvAttendence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAttendence.BorderStyle = BorderStyle.None;
            dgvAttendence.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvAttendence.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAttendence.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvAttendence.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvAttendence.BackgroundColor = Color.White;

            dgvAttendence.EnableHeadersVisualStyles = false;
            dgvAttendence.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAttendence.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvAttendence.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void disable_Button()
        {
            var date = DateTime.Now.Date;
            string query = "Select count(*) from ClassAttendance where AttendanceDate = '" + date + "'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = (int)sqlcmd.ExecuteScalar();
            if(count > 0)
            {
                btnSubmit.Enabled = false;
                lblAtt1.Text = "Attendance";
                lblAtt2.Text = "Already Marked";
            }
            else
            {
                btnSubmit.Enabled = true;
                lblAtt1.Text = "";
                lblAtt2.Text = "";
            }
        }
    }
}
