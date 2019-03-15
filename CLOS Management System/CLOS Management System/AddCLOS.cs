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
    public partial class AddCLOS : UserControl
    {
        public AddCLOS()
        {
            InitializeComponent();
            dgv_Design();
            dgv_load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var date = DateTime.Now.Date;
                string query = "Insert Into Clo(Name, DateCreated, DateUpdated) Values('" + txtCLOName.Text + "', '" + date + "', '" + date + "')";
                string messege = txtCLOName.Text + " Added Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtCLOName.Text = "";
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
                int id = Convert.ToInt32(lblID.Text);
                var date = DateTime.Now.Date;
                string query = "Update Clo set Name = '" + txtCLOName.Text + "', DateUpdated = '" + date + "' " +
                    "Where Id = '" + id + "'";
                string messege = txtCLOName.Text + " Updated Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtCLOName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                string query = "Delete Clo " +
                    "Where Id = '" + id + "'";
                string messege = txtCLOName.Text + " Deleted Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtCLOName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_load()
        {
            try
            {
                string query = "Select * from Clo Order by Id";
                SqlDataAdapter sqladp = new SqlDataAdapter(query, DatabaseConnection.getInstance().getConnection());
                DataTable tbl = new DataTable();
                sqladp.Fill(tbl);
                dgvClOData.DataSource = tbl;
                DatabaseConnection.getInstance().getConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgv_Design()
        {
            dgvClOData.ReadOnly = true;
            dgvClOData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClOData.BorderStyle = BorderStyle.None;
            dgvClOData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvClOData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClOData.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvClOData.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvClOData.BackgroundColor = Color.White;

            dgvClOData.EnableHeadersVisualStyles = false;
            dgvClOData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClOData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvClOData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvClOData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClOData.SelectedCells.Count > 0)
            {
                string id = dgvClOData.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblID.Text = id;

                int n = Convert.ToInt32(id);

                string query = "Select * from Clo where Id = '" + n + "'";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while(reader.Read())
                {
                    txtCLOName.Text = reader["Name"].ToString();
                }
                DatabaseConnection.getInstance().closeConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int parse;
                if(Int32.TryParse(txtSearchCLO.Text, out parse))
                {
                    int id = Convert.ToInt32(txtSearchCLO.Text);
                    searchCLO("", id);
                }
                else
                {
                    searchCLO(txtSearchCLO.Text, 0);
                }
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
        }

        private void searchCLO(string text, int number)
        {
            string query1 = "Select count(*) from Clo where Name = '" + text + "' or Id = '" + number + "'";
            SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            int count = (int)sqlcmd.ExecuteScalar();
            if (count > 0)
            {
                string query2 = "Select * from Clo where Name = '" + txtSearchCLO.Text + "' or Id = '" + number + "'";
                SqlDataAdapter sqladp = new SqlDataAdapter(query2, DatabaseConnection.getInstance().getConnection());
                DataTable tbl = new DataTable();
                sqladp.Fill(tbl);
                dgvClOData.DataSource = tbl;
                DatabaseConnection.getInstance().closeConnection();
                txtSearchCLO.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                txtSearchCLO.Text = "";
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgv_load();
        }
    }
}
