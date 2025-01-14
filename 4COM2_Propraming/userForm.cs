using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace _4COM2_Propraming
{
    public partial class suplyerForm : Form
    {
        public suplyerForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=DESKTOP-I9TUAQ1\SQLEXPRESS;Initial Catalog=minidb_4com;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        private void showData()
        {
            sqlCmd = new SqlCommand("select * from tbSuppliers", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດຜູ້ສະໜອງ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ຜູ້ສະໜອງ";
            dataGridView1.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
            dataGridView1.Columns[3].HeaderText = "ທີ່ຢູ່";
            dataGridView1.Columns[4].HeaderText = "ເບີໂທ";
            dataGridView1.Columns[5].HeaderText = "ອີເມລ";
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbSuppliers (supplier_id, supplier_name, contract_name, address, telephone, email) VALUES (@supplier_id, @supplier_name, @contract_name, @address, @telephone, @email)";
            using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
            {
                cmd.Parameters.AddWithValue("@supplier_id", sup_ID.Text);
                cmd.Parameters.AddWithValue("@supplier_name", sub_name.Text);
                cmd.Parameters.AddWithValue("@contract_name", cont_name.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@telephone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
            }
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbSuppliers SET supplier_name = @supplier_name, contract_name = @contract_name, address = @address, telephone = @telephone, email = @email WHERE supplier_id = @supplier_id";
            using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
            {
                cmd.Parameters.AddWithValue("@supplier_id", sup_ID.Text);
                cmd.Parameters.AddWithValue("@supplier_name", sub_name.Text);
                cmd.Parameters.AddWithValue("@contract_name", cont_name.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@telephone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
            }
            showData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dataGridView1.CurrentRow.Index;
            sup_ID.Text = dataGridView1.Rows[cindex].Cells[0].Value.ToString();
            sub_name.Text = dataGridView1.Rows[cindex].Cells[1].Value.ToString();
            cont_name.Text = dataGridView1.Rows[cindex].Cells[2].Value.ToString();
            address.Text = dataGridView1.Rows[cindex].Cells[3].Value.ToString();
            phone.Text = dataGridView1.Rows[cindex].Cells[4].Value.ToString();
            email.Text = dataGridView1.Rows[cindex].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "Delete from tbSuppliers where supplier_id = @supplier_id";
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@supplier_id", sup_ID.Text); // Use primary key to identify the record
                    cmd.ExecuteNonQuery();
                }
                showData();
            }
        }
    }
}
