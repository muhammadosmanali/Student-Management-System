using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOS_Management_System
{
    public partial class Student : UserControl
    {
        public Student()
        {
            InitializeComponent();
        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            AddStudent obj = new AddStudent();
            Controls.Add(obj);
            obj.BringToFront();
        }

        private void btnMarkAttendence_Click(object sender, EventArgs e)
        {
            MarkAttendence obj = new MarkAttendence();
            Controls.Add(obj);
            obj.BringToFront();
        }
    }
}
