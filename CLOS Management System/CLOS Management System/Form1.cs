using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOS_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            Controls.Add(obj);
            obj.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Home obj = new Home();
            Controls.Add(obj);
            obj.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            Controls.Add(obj);
            obj.BringToFront();
        }
    }
}
