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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        private void studentCount()
        {
            string query = "Select count(*) from Student";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = (int)sqlcmd.ExecuteScalar();
            lblStudentCount.Text = count.ToString();
            progressBarStudent.Maximum = 200;
            progressBarStudent.Step = 1;
            progressBarStudent.Value = count;
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
