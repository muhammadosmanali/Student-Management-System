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
    public partial class AddStudent : UserControl
    {
        public AddStudent()
        {
            InitializeComponent();
            combobox_Load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) " +
                "Values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtRegNo.Text + "', '" + status() + "')";

                string messege = txtFirstName.Text + " " + txtLastName.Text + " Added Successfully";

                add_Update_Delete(query, messege);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Update Student Set FirstName = '" + txtFirstName.Text + "', " +
                    "LastName = '" + txtLastName.Text + "', " +
                    "Contact = '" + txtContact.Text + "', " +
                    "Email = '" + txtEmail.Text + "', " +
                    "RegistrationNumber = '" + txtRegNo.Text + "', " +
                    "Status = '" + status() + "' " +
                    "Where RegistrationNumber = '" + txtRegNo.Text + "'";

                string messege = txtFirstName.Text + " " + txtLastName.Text + " Updated Successfully";

                add_Update_Delete(query, messege);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_Update_Delete(string query, string messege)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show(messege);
            clear();
            DatabaseConnection.getInstance().closeConnection();
        }

        private int status()
        {
            int status;
            if (cmbStatus.Text == "Current Student")
                status = 5;
            else
                status = 6;

            return status;
        }

        private void clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text
                = txtEmail.Text = txtRegNo.Text = cmbStatus.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtFirstName.Text != "" && txtEmail.Text != "" && txtRegNo.Text != "" && cmbStatus.Text != "")
                {
                    string query = "Delete Student Where RegistrationNumber = '" + txtRegNo.Text + "'";
                    string messege = txtFirstName.Text + " " + txtLastName.Text + " Deleted Successfully";

                    add_Update_Delete(query, messege);
                }
                else
                {
                    lblErrorMessege.Text = "Required Fields are Empty";
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "Select * from Student where RegistrationNumber = '" + cmbRegNo.Text + "'";
                studentSearch(query);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbRegNo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "Select count(*) from Student where RegistrationNumber = '" + txtSearchStudent.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
                int count = (int)sqlcmd.ExecuteScalar();
                if(count > 0)
                {
                    string query2 = "Select * from Student where RegistrationNumber = '" + txtSearchStudent.Text + "'";
                    studentSearch(query2);
                    txtSearchStudent.Text = "";
                }
                else
                {
                    MessageBox.Show("Not Found");
                    txtSearchStudent.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentSearch(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                txtFirstName.Text = reader["FirstName"].ToString();
                txtLastName.Text = reader["LastName"].ToString();
                txtContact.Text = reader["Contact"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtRegNo.Text = reader["RegistrationNumber"].ToString();

                int status = Convert.ToInt32(reader["Status"]);
                if (status == 1)
                {
                    cmbStatus.Text = "Current Student";
                }
                else
                {
                    cmbStatus.Text = "Not Student Anymore";
                }
            }
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
