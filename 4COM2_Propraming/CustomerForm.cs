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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4COM2_Propraming
{
    public partial class CustomerForm : Form
    {
        string strConnect = @"Data Source=DESKTOP-I9TUAQ1\SQLEXPRESS;Initial Catalog=minidb_4com;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        SqlConnection? conn = null;
        SqlCommand? cmd = null;
        SqlDataReader? reader = null;
        SqlDataAdapter? adapter = null;

        public CustomerForm()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }

        private void getData()
        {
            string sql = "select * from tbCustomers";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "ລະຫັດ";
            dgv.Columns[1].HeaderText = "ຊື່";
            dgv.Columns[2].HeaderText = "ທີ່ຢູ່";
            dgv.Columns[3].HeaderText = "ເບີໂທ";
        }
        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbCustomers (cust_id, cust_Name, cust_Address, telephone) VALUES (@cust_id, @cust_Name, @cust_Address, @telephone)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@cust_id", idTxt.Text);
                cmd.Parameters.AddWithValue("@cust_Name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@cust_Address", addressTxt.Text);
                cmd.Parameters.AddWithValue("@telephone", phoneTxt.Text);
                cmd.ExecuteNonQuery();
            }
            getData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbCustomers SET cust_Name = @cust_Name, cust_Address = @cust_Address, telephone = @telephone WHERE cust_id = @cust_id";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@cust_id", idTxt.Text); // Match by primary key
                cmd.Parameters.AddWithValue("@cust_Name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@cust_Address", addressTxt.Text);
                cmd.Parameters.AddWithValue("@telephone", phoneTxt.Text);
                cmd.ExecuteNonQuery();
            }
            getData();
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgv.CurrentRow.Index;
            idTxt.Text = dgv.Rows[cindex].Cells[0].Value.ToString();
            nameTxt.Text = dgv.Rows[cindex].Cells[1].Value.ToString();
            addressTxt.Text = dgv.Rows[cindex].Cells[2].Value.ToString();
            phoneTxt.Text = dgv.Rows[cindex].Cells[3].Value.ToString();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM tbCustomers WHERE cust_id = @cust_id";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cust_id", idTxt.Text); // Use primary key to identify the record
                    cmd.ExecuteNonQuery();
                }
                getData();
            }
        }
    }
}
