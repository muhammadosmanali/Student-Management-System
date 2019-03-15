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
    public partial class CLOS : UserControl
    {
        public CLOS()
        {
            InitializeComponent();
        }

        private void btnManageCLOS_Click(object sender, EventArgs e)
        {
            AddCLOS obj = new AddCLOS();
            Controls.Add(obj);
            obj.BringToFront();
        }

        private void btnManageRubrics_Click(object sender, EventArgs e)
        {
            AddRubrics obj = new AddRubrics();
            Controls.Add(obj);
            obj.BringToFront();
        }
    }
}
