using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _4COM2_Propraming
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=DESKTOP-I9TUAQ1\SQLEXPRESS;Initial Catalog=minidb_4com;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = txtPwd.Text;
            string sql = "select * from tbusers where userName = '" + username + "' and password_code = '"+ pwd +"'";
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand(sql, sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("ຍິນດີຕ້ອນຮັບ");
                frmMainMenu frm = new frmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();
            } 
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ລະບົບ ຫຼື ລະຫັດຜ່ານບໍ່ຖືກຕ້ອງ");
            }
        }
    }
}
