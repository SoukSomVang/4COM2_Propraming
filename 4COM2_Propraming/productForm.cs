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
    public partial class productForm : Form
    {
        string strConnect = @"Data Source=DESKTOP-I9TUAQ1\SQLEXPRESS;Initial Catalog=minidb_4com;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        SqlConnection? conn = null;
        SqlCommand? cmd = null;
        SqlDataReader? reader = null;
        SqlDataAdapter? adapter = null;

        public productForm()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();

        }
        private void getData()
        {
            string sql = "select * from tbProductType";
            cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ລະຫັດປະເພດ";
            dataGridView1.Columns[1].HeaderText = "ຊື່ປະເພດ";
        }
        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void addData(string id, string name)
        {
            if (id != "" && name != "")
            {
                string sql = "INSERT INTO tbProductType (ptType_ID, ptType_name) VALUES (@Id, @Name)";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    cmd.ExecuteNonQuery();
                    getData();
                }
                catch { }
            }
            else
            {
                MessageBox.Show("ກະລຸນາຕື່ມໃຫ້ຄົບ");
            }
        }

        private void editData(string id, string name)
        {
            if (id != "" && name != "")
            {
                string sql = "UPDATE tbProductType SET ptType_name = @Name WHERE ptType_ID = @Id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                try
                {
                    cmd.ExecuteNonQuery();
                    getData();
                    MessageBox.Show("ອັບເດດຂໍ້ມູນສຳເລັດ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ກະລຸນາຕື່ມໃຫ້ຄົບ");
            }
        }

        private void deleteData(string id)
        {
            if (id != "")
            {
                string sql = "DELETE FROM tbProductType WHERE ptType_ID = @Id";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                try
                {
                    cmd.ExecuteNonQuery();
                    getData();
                    MessageBox.Show("ລຶບຂໍ້ມູນສຳເລັດ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("ກະລຸນາເລືອກລາຍການທີ່ຈະລຶບ");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT tbProductType values('"+ textBox1.Text +"','" + textBox2.Text + "')";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ","Question", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            { 
                string sql = "DELETE tbProductType WHERE ptType_ID ='" + textBox1.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbProductType SET ptType_name =N'"+ textBox2.Text +"'WHERE ptType_ID ='"+ textBox1.Text +"'";
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[cindex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[cindex].Cells[1].Value.ToString();

        }
    }
}
