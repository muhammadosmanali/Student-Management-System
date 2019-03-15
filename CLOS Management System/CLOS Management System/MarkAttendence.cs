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
            disable_Button("Attendance", "Already Marked");
            dgv_Design();
            
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.Date;
            string query1 = "Insert Into ClassAttendance(AttendanceDate) OUTPUT INSERTED.ID Values('" + date + "')";
            SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            int classId = Convert.ToInt32(sqlcmd.ExecuteScalar());

            for (int i = 0; i < dgvAttendence.Rows.Count - 1; i++)
            {
                //Get Student Id
                int studentId = 0;
                string query2 = "Select * from Student where RegistrationNumber = '" + dgvAttendence.Rows[i].Cells[2].Value.ToString() + "'";
                SqlCommand sqlcmd2 = new SqlCommand(query2, DatabaseConnection.getInstance().getConnection());
                SqlDataReader reader = sqlcmd2.ExecuteReader();
                while(reader.Read())
                {
                    studentId = (int)reader["Id"];
                }

                //Generate attendance
                int attendanceId = 0;
                if (dgvAttendence.Rows[i].Cells[0].Value == null)
                {
                    attendanceId = 2;
                }
                else
                {
                    attendanceId = 1;
                }

                //Insert into Table
                string query3 = "Insert Into StudentAttendance(AttendanceId, StudentId, AttendanceStatus) " +
                    "Values('" + classId + "', '" + studentId + "', '" + attendanceId + "')";
                SqlCommand sqlcmd3 = new SqlCommand(query3, DatabaseConnection.getInstance().getConnection());
                sqlcmd3.ExecuteNonQuery();
            }
            DatabaseConnection.getInstance().closeConnection();
            MessageBox.Show("Attendence Marked Successfully");

            for (int i = 0; i < dgvAttendence.Rows.Count - 1; i++)
            {
                dgvAttendence.Rows[i].Cells[0].Value = null;
            }

            disable_Button("Today", "Attendance Marked");
        }

        private void disable_Button(string text1, string text2)
        {
            var date = DateTime.Now.Date;
            string query = "Select count(*) from ClassAttendance where AttendanceDate = '" + date + "'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = (int)sqlcmd.ExecuteScalar();
            if(count > 0)
            {
                btnSubmit.Enabled = false;
                lblAtt1.Text = text1;
                lblAtt2.Text = text2;
            }
            else
            {
                btnSubmit.Enabled = true;
                lblAtt1.Text = "";
                lblAtt2.Text = "";
            }
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
    }
}
