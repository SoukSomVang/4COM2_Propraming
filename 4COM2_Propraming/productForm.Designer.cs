namespace _4COM2_Propraming
{
    partial class productForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Saysettha OT", 9F);
            label1.Location = new Point(254, 38);
            label1.Name = "label1";
            label1.Size = new Size(150, 24);
            label1.TabIndex = 0;
            label1.Text = "ຟອມຂໍ້ມູນປະເພດສິນຄ້າ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Saysettha OT", 9F);
            label2.Location = new Point(126, 79);
            label2.Name = "label2";
            label2.Size = new Size(95, 24);
            label2.TabIndex = 1;
            label2.Text = "ຮັບຂໍ້ມູນສິນຄ້າ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Saysettha OT", 9F);
            label3.Location = new Point(126, 141);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 2;
            label3.Text = "ລະຫັດປະເພດ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Saysettha OT", 9F);
            label4.Location = new Point(126, 190);
            label4.Name = "label4";
            label4.Size = new Size(103, 24);
            label4.TabIndex = 3;
            label4.Text = "ຊື່ປະເພດສິນຄ້າ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Saysettha OT", 9F);
            textBox1.Location = new Point(228, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Saysettha OT", 9F);
            textBox2.Location = new Point(228, 187);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 186);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.Font = new Font("Saysettha OT", 9F);
            button1.Location = new Point(187, 400);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "ເຂົ້າຂໍ້ມູນ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Saysettha OT", 9F);
            button2.Location = new Point(426, 400);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "ລົບຂໍ້ມູນ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Wheat;
            button3.Font = new Font("Saysettha OT", 9F);
            button3.Location = new Point(309, 400);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "ແກ້ໄຂຂໍ້ມູນ";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(566, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(507, 343);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // productForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 563);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "productForm";
            Text = "productForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}