namespace _4COM2_Propraming
{
    partial class CustomerForm
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
            groupBox1 = new GroupBox();
            delete = new Button();
            edit = new Button();
            add = new Button();
            phoneTxt = new TextBox();
            label5 = new Label();
            addressTxt = new TextBox();
            nameTxt = new TextBox();
            idTxt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgv = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Saysettha OT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 48);
            label1.TabIndex = 0;
            label1.Text = "ຂໍ້ມູນລູກຄ້າ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete);
            groupBox1.Controls.Add(edit);
            groupBox1.Controls.Add(add);
            groupBox1.Controls.Add(phoneTxt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(addressTxt);
            groupBox1.Controls.Add(nameTxt);
            groupBox1.Controls.Add(idTxt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Saysettha OT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 227);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ປ້ອນຂໍ້ມູນ";
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Location = new Point(345, 167);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 10;
            delete.Text = "ລຶບ";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click_1;
            // 
            // edit
            // 
            edit.BackColor = Color.Yellow;
            edit.Location = new Point(222, 167);
            edit.Name = "edit";
            edit.Size = new Size(94, 29);
            edit.TabIndex = 9;
            edit.Text = "ແກ້ໄຂ";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // add
            // 
            add.BackColor = Color.LawnGreen;
            add.Location = new Point(98, 167);
            add.Name = "add";
            add.Size = new Size(94, 29);
            add.TabIndex = 8;
            add.Text = "ເພີ່ມ";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // phoneTxt
            // 
            phoneTxt.Location = new Point(426, 80);
            phoneTxt.Name = "phoneTxt";
            phoneTxt.Size = new Size(210, 34);
            phoneTxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 83);
            label5.Name = "label5";
            label5.Size = new Size(83, 24);
            label5.TabIndex = 6;
            label5.Text = "ເບີໂທລະສັບ";
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(106, 116);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(530, 34);
            addressTxt.TabIndex = 5;
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(106, 80);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(210, 34);
            nameTxt.TabIndex = 4;
            // 
            // idTxt
            // 
            idTxt.Location = new Point(106, 33);
            idTxt.Multiline = true;
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(210, 29);
            idTxt.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 119);
            label4.Name = "label4";
            label4.Size = new Size(29, 24);
            label4.TabIndex = 2;
            label4.Text = "ທີ່ຢູ່";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 83);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 1;
            label3.Text = "ຊື່ລູກຄ້າ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 36);
            label2.Name = "label2";
            label2.Size = new Size(87, 24);
            label2.TabIndex = 0;
            label2.Text = "ລະຫັດລູກຄ້າ";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 323);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(776, 188);
            dgv.TabIndex = 2;
            dgv.CellMouseClick += dgv_CellMouseClick;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button edit;
        private Button add;
        private TextBox phoneTxt;
        private Label label5;
        private TextBox addressTxt;
        private TextBox nameTxt;
        private TextBox idTxt;
        private Label label4;
        private Label label3;
        private Button delete;
        private DataGridView dgv;
    }
}