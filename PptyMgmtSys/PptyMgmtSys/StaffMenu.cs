using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PptyMgmtSys
{
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void newTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new createTenant().Show();
        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
