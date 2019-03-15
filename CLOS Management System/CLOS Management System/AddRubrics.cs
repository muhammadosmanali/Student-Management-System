using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CLOS_Management_System
{
    public partial class AddRubrics : UserControl
    {
        public AddRubrics()
        {
            InitializeComponent();
        }

        private void AddRubrics_Load(object sender, EventArgs e)
        {
            dgv_load();
            dgv_Design();
            cmb_load();
        }

        private void dgv_load()
        {
            string query = "Select * from Rubric Order by Id";
            SqlDataAdapter sqladp = new SqlDataAdapter(query, DatabaseConnection.getInstance().getConnection());
            DataTable tbl = new DataTable();
            sqladp.Fill(tbl);
            dgvRubricData.DataSource = tbl;
            DatabaseConnection.getInstance().closeConnection();
        }

        private void dgv_Design()
        {
            dgvRubricData.ReadOnly = true;
            dgvRubricData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRubricData.BorderStyle = BorderStyle.None;
            dgvRubricData.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvRubricData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRubricData.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgvRubricData.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvRubricData.BackgroundColor = Color.White;

            dgvRubricData.EnableHeadersVisualStyles = false;
            dgvRubricData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRubricData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvRubricData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dgvRubricData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRubricData.SelectedCells.Count > 0)
            {
                string id = dgvRubricData.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblID.Text = id;

                int n = Convert.ToInt32(id);

                string query = "Select * from Rubric Inner Join Clo On Rubric.CloId = Clo.Id Where Rubric.Id = '" + n + "'";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbCLO.Text = reader["CloId"].ToString() + " " + reader["Name"].ToString();
                    txtRubricDetail.Text = reader["Details"].ToString();
                }
                DatabaseConnection.getInstance().closeConnection();
            }
        }

        private void cmb_load()
        {
            string query = "Select * from Clo order by Id";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while(reader.Read())
            {
                cmbCLO.Items.Add(reader["Id"].ToString() + " " + reader["Name"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgv_load();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = "Select count(*) from Rubric";
                SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
                int count = (int)sqlcmd.ExecuteScalar();
                int RubricId = count + 1;

                string number = Regex.Match(cmbCLO.Text, @"\d+").Value;
                int id = Convert.ToInt32(number);
                string query = "Insert Into Rubric(Id, Details, CloId) Values('" + RubricId + "' ,'" + txtRubricDetail.Text + "', '" + id + "')";
                string messege = "Rubric Added Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtRubricDetail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblID.Text);
                string number = Regex.Match(cmbCLO.Text, @"\d+").Value;
                int CloId = Convert.ToInt32(number);
                string query = "Update Rubric set Details = '" + txtRubricDetail.Text + "', CloId = '" + CloId + "' " +
                    "Where Id = '" + id + "'";
                string messege = "Rubric Updated Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtRubricDetail.Text = "";
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
                string query = "Delete Rubric " +
                    "Where Id = '" + id + "'";
                string messege = "Rubric Deleted Successfully";
                DatabaseConnection.getInstance().add_Update_Delete(query, messege);
                dgv_load();
                txtRubricDetail.Text = "";
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
                searchCLO();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void searchCLO()
        {
            int id = Convert.ToInt32(txtSearchRubric.Text);
            string query1 = "Select count(*) from Rubric where CloId = '" + id + "'";
            SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            int count = (int)sqlcmd.ExecuteScalar();
            if (count > 0)
            {
                string query2 = "Select * from Rubric where CloId = '" + id + "'";
                SqlDataAdapter sqladp = new SqlDataAdapter(query2, DatabaseConnection.getInstance().getConnection());
                DataTable tbl = new DataTable();
                sqladp.Fill(tbl);
                dgvRubricData.DataSource = tbl;
                DatabaseConnection.getInstance().closeConnection();
                txtSearchRubric.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                txtSearchRubric.Text = "";
            }
        }
    }
}
