namespace _4COM2_Propraming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15 + 5" + (15 + 5));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button1.ForeColor = Color.Red;
            button1.Text = "Calculate";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.Text = "ຄຳນວນ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "test";
        }
    }
}
