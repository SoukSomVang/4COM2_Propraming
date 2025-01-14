using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4COM2_Propraming
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void ອອກຈາກລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ຂມນToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suplyerForm frm = new suplyerForm();
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
            //frm.MdiParent = this;
        }
    }
}
