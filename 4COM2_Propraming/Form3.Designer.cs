namespace _4COM2_Propraming
{
    partial class Form3
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(69, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(382, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ແບບ DateTimeFormateInfoCurrentInfo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(69, 71);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(358, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ແບບ DateTimeFormateInvariantInfo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Saysettha OT", 12F);
            label2.Location = new Point(106, 268);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 3;
            label2.Text = "ກຳນົດຮູບແບບ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Saysettha OT", 12F);
            label3.Location = new Point(623, 110);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 4;
            label3.Text = "ຜົນໄດ້ຮັບ:";
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Saysettha OT", 12F);
            label4.Location = new Point(518, 160);
            label4.Name = "label4";
            label4.Size = new Size(270, 50);
            label4.TabIndex = 5;
            label4.Text = "ຜົນຮັບ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Saysettha OT", 12F);
            button1.Location = new Point(610, 253);
            button1.Name = "button1";
            button1.Size = new Size(125, 52);
            button1.TabIndex = 7;
            button1.Text = "ຈັດຮູບແບບ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Font = new Font("Saysettha OT", 12F);
            groupBox1.Location = new Point(38, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 125);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "ກຳນົດລັກສະນະ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Saysettha OT", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(242, 265);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 40);
            comboBox1.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}