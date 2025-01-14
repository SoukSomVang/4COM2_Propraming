namespace _4COM2_Propraming
{
    partial class Form2
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
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResult = new TextBox();
            minusBtn = new Button();
            label4 = new Label();
            multiplyBtn = new Button();
            devideBtn = new Button();
            plusBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Saysettha OT", 12F);
            label1.Location = new Point(232, 110);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "ຄ່າທີ່ 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Saysettha OT", 12F);
            label2.Location = new Point(232, 169);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 1;
            label2.Text = "ຄ່າທີ່ 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Saysettha OT", 12F);
            label3.Location = new Point(231, 233);
            label3.Name = "label3";
            label3.Size = new Size(98, 32);
            label3.TabIndex = 2;
            label3.Text = "ຜົນໄດ້ຮັບ:";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Saysettha OT", 12F);
            txtNum1.Location = new Point(335, 107);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(229, 42);
            txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Saysettha OT", 12F);
            txtNum2.Location = new Point(335, 166);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(229, 42);
            txtNum2.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Saysettha OT", 12F);
            txtResult.Location = new Point(335, 223);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(229, 42);
            txtResult.TabIndex = 5;
            // 
            // minusBtn
            // 
            minusBtn.Font = new Font("Saysettha OT", 12F);
            minusBtn.Location = new Point(282, 316);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(117, 43);
            minusBtn.TabIndex = 6;
            minusBtn.Text = "ລົບ";
            minusBtn.UseVisualStyleBackColor = true;
            minusBtn.Click += minusBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Saysettha OT", 12F);
            label4.Location = new Point(270, 40);
            label4.Name = "label4";
            label4.Size = new Size(294, 32);
            label4.TabIndex = 7;
            label4.Text = "ໂປຣເເກຣມຄຳນວນເລກສອງຈຳນວນ";
            // 
            // multiplyBtn
            // 
            multiplyBtn.Font = new Font("Saysettha OT", 12F);
            multiplyBtn.Location = new Point(420, 316);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(117, 43);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "ຄູນ";
            multiplyBtn.UseVisualStyleBackColor = true;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // devideBtn
            // 
            devideBtn.Font = new Font("Saysettha OT", 12F);
            devideBtn.Location = new Point(553, 316);
            devideBtn.Name = "devideBtn";
            devideBtn.Size = new Size(117, 43);
            devideBtn.TabIndex = 9;
            devideBtn.Text = "ຫານ";
            devideBtn.UseVisualStyleBackColor = true;
            devideBtn.Click += devideBtn_Click;
            // 
            // plusBtn
            // 
            plusBtn.Font = new Font("Saysettha OT", 12F);
            plusBtn.Location = new Point(146, 316);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(117, 43);
            plusBtn.TabIndex = 10;
            plusBtn.Text = "ບວກ";
            plusBtn.UseVisualStyleBackColor = true;
            plusBtn.Click += plusBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(plusBtn);
            Controls.Add(devideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(label4);
            Controls.Add(minusBtn);
            Controls.Add(txtResult);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResult;
        private Button minusBtn;
        private Label label4;
        private Button multiplyBtn;
        private Button devideBtn;
        private Button plusBtn;
    }
}