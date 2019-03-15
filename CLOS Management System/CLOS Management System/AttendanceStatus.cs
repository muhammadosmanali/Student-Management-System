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
    public partial class AttendanceStatus : UserControl
    {
        public AttendanceStatus()
        {
            InitializeComponent();
        }

        private void AttendanceStatus_Load(object sender, EventArgs e)
        {
            combobox_Load();
        }

        private void combobox_Load()
        {
            try
            {
                string query = "Select * from Student Order by RegistrationNumber";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbRegNo.Items.Add(reader["RegistrationNumber"].ToString());
                }
                DatabaseConnection.getInstance().getConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "Select count(*) from Student where RegistrationNumber = '" + txtSearchStudent.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
                int count = (int)sqlcmd.ExecuteScalar();
                if (count > 0)
                {
                    string query2 = "Select * from Student " +
                        "Inner Join StudentAttendance " +
                        "On Student.Id = StudentAttendance.StudentId " +
                        " Where RegistrationNumber = '" + txtSearchStudent.Text + "' ";
                    att_Percentage(query2);
                    txtSearchStudent.Text = "";
                }
                else
                {
                    MessageBox.Show("Not Found");
                    txtSearchStudent.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void att_Percentage(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            int total_att = 0;
            int actual_att = 0;
            while(reader.Read())
            {
                total_att += 1;
                if(reader["AttendanceStatus"].ToString() == "1")
                {
                    actual_att += 1;
                }
            }

            if(total_att == 0)
            {
                lblPercentage.Text = "No Attendance";
            }
            else
            {
                int percentage = (int)Math.Round((double)(100 * actual_att) / total_att);
                lblPercentage.Text = percentage.ToString() + " % Attendance";
            }
            

        }

        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select * from Student " +
                "Inner Join StudentAttendance " +
                "On Student.Id = StudentAttendance.StudentId " +
                " Where RegistrationNumber = '" + cmbRegNo.Text + "' ";
            att_Percentage(query);
        }
    }
}
