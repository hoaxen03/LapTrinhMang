namespace Bai_Tap_Tuan_1
{
    partial class TimSoMinMax
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(350, 103);
            button1.Name = "button1";
            button1.Size = new Size(146, 59);
            button1.TabIndex = 0;
            button1.Text = "Xóa hết";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(149, 103);
            button2.Name = "button2";
            button2.Size = new Size(141, 59);
            button2.TabIndex = 1;
            button2.Text = "Tìm kiếm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(491, 208);
            button3.Name = "button3";
            button3.Size = new Size(159, 23);
            button3.TabIndex = 2;
            button3.Text = "Thoát chương trình";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 3;
            label1.Text = "Tìm Số Lớn Nhất Và Nhỏ Nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 77);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Số thứ hai";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 77);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 6;
            label4.Text = "Số thứ ba";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 167);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "Số lớn nhất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 167);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 8;
            label6.Text = "Số nhỏ nhất";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(521, 74);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(320, 164);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(110, 208);
            button4.Name = "button4";
            button4.Size = new Size(222, 23);
            button4.TabIndex = 14;
            button4.Text = "Chuyển sang chương trình tiếp theo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TimSoMinMax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 243);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TimSoMinMax";
            Text = "TimSoMinMax";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button4;
    }
}