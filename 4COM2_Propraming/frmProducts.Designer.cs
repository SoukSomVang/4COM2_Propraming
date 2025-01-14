namespace _4COM2_Propraming
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnChoose = new Button();
            pictureBox1 = new PictureBox();
            cboType = new ComboBox();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            txtInstock = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtUnit = new TextBox();
            label6 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtQty = new TextBox();
            label4 = new Label();
            txtProName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dgvShowdata = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtProNo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowdata).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnChoose
            // 
            btnChoose.BackColor = Color.FromArgb(0, 0, 192);
            btnChoose.Font = new Font("Saysettha OT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChoose.ForeColor = Color.White;
            btnChoose.Image = (Image)resources.GetObject("btnChoose.Image");
            btnChoose.ImageAlign = ContentAlignment.MiddleLeft;
            btnChoose.Location = new Point(1123, 458);
            btnChoose.Margin = new Padding(4, 5, 4, 5);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(169, 65);
            btnChoose.TabIndex = 7;
            btnChoose.Text = "ເລືອກຮູບ";
            btnChoose.TextAlign = ContentAlignment.MiddleRight;
            btnChoose.UseVisualStyleBackColor = false;
            btnChoose.Click += btnChoose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(896, 171);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(395, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // cboType
            // 
            cboType.FormattingEnabled = true;
            cboType.Location = new Point(252, 336);
            cboType.Margin = new Padding(4, 5, 4, 5);
            cboType.Name = "cboType";
            cboType.Size = new Size(335, 40);
            cboType.TabIndex = 5;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 64, 0);
            btnDelete.Font = new Font("Saysettha OT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(593, 458);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(169, 65);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "ລົບຂໍ້ມູນ";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 192, 128);
            btnEdit.Font = new Font("Saysettha OT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Location = new Point(399, 458);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(169, 65);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Font = new Font("Saysettha OT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(204, 458);
            btnAdd.Margin = new Padding(4, 5, 4, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(169, 65);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtInstock
            // 
            txtInstock.Location = new Point(252, 391);
            txtInstock.Margin = new Padding(4, 5, 4, 5);
            txtInstock.Name = "txtInstock";
            txtInstock.Size = new Size(437, 42);
            txtInstock.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 402);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(208, 32);
            label9.TabIndex = 0;
            label9.Text = "ເກນສິນຄ້າເຫຼືອໜ້ອຍສຸດ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 349);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 32);
            label8.TabIndex = 0;
            label8.Text = "ປະເພດສິນຄ້າ:";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(252, 282);
            txtUnit.Margin = new Padding(4, 5, 4, 5);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(335, 42);
            txtUnit.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 292);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(91, 32);
            label6.TabIndex = 0;
            label6.Text = "ຫົວໜ່ວຍ:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(252, 225);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(540, 42);
            txtPrice.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 235);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(123, 32);
            label5.TabIndex = 0;
            label5.Text = "ລາຄາຕໍ່ໜ່ວຍ:";
            // 
            // txtQty
            // 
            txtQty.Location = new Point(252, 168);
            txtQty.Margin = new Padding(4, 5, 4, 5);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(335, 42);
            txtQty.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(129, 32);
            label4.TabIndex = 0;
            label4.Text = "ຈຳນວນສີນຄ້າ:";
            // 
            // txtProName
            // 
            txtProName.Location = new Point(252, 109);
            txtProName.Margin = new Padding(4, 5, 4, 5);
            txtProName.Name = "txtProName";
            txtProName.Size = new Size(1040, 42);
            txtProName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 0;
            label3.Text = "ຊື່ສິນຄ້າ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 0;
            label2.Text = "ລະຫັດສິນຄ້າ:";
            // 
            // dgvShowdata
            // 
            dgvShowdata.AllowUserToAddRows = false;
            dgvShowdata.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvShowdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Saysettha OT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvShowdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvShowdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShowdata.Location = new Point(17, 655);
            dgvShowdata.Margin = new Padding(4, 5, 4, 5);
            dgvShowdata.Name = "dgvShowdata";
            dgvShowdata.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Font = new Font("Saysettha OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvShowdata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvShowdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowdata.Size = new Size(1327, 134);
            dgvShowdata.TabIndex = 8;
            dgvShowdata.CellMouseClick += dgvShowdata_CellMouseClick;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Saysettha OT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1368, 71);
            label1.TabIndex = 6;
            label1.Text = "ຟອມຂໍ້ມູນສິນຄ້າ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnChoose);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cboType);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtInstock);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtUnit);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtQty);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtProName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtProNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Saysettha OT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 110);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1325, 535);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "ຮັບຂໍ້ມູນສິນຄ້າ";
            // 
            // txtProNo
            // 
            txtProNo.Location = new Point(252, 51);
            txtProNo.Margin = new Padding(4, 5, 4, 5);
            txtProNo.Name = "txtProNo";
            txtProNo.Size = new Size(540, 42);
            txtProNo.TabIndex = 1;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 795);
            Controls.Add(dgvShowdata);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShowdata).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInstock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShowdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProNo;
    }
}