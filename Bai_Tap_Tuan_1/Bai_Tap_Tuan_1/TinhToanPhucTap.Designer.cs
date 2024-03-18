namespace Bai_Tap_Tuan_1
{
    partial class TinhToanPhucTap
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(95, 92);
            button1.Name = "button1";
            button1.Size = new Size(126, 86);
            button1.TabIndex = 0;
            button1.Text = "Thực hiện phép tính";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 92);
            button2.Name = "button2";
            button2.Size = new Size(123, 86);
            button2.TabIndex = 1;
            button2.Text = "Xóa ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(479, 387);
            button3.Name = "button3";
            button3.Size = new Size(171, 27);
            button3.TabIndex = 2;
            button3.Text = "Thoát chương trình";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(417, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(89, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(365, 53);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Nhập B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 45);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "A! =";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 81);
            label4.Name = "label4";
            label4.Size = new Size(152, 15);
            label4.TabIndex = 8;
            label4.Text = "S1 = 1 + 2 + 3 + 4 +...+ A = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 120);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 9;
            label5.Text = "S2 = 1 + 2 + 3 + 4+...+B =";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 160);
            label6.Name = "label6";
            label6.Size = new Size(228, 15);
            label6.TabIndex = 10;
            label6.Text = "S3 = A^1 + A^2 + A^3 + A^4 +...+ A^B =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 45);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "B! =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(202, 9);
            label8.Name = "label8";
            label8.Size = new Size(270, 32);
            label8.TabIndex = 12;
            label8.Text = "Tính toán anh sờ tanh";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(54, 45);
            label9.Name = "label9";
            label9.Size = new Size(0, 15);
            label9.TabIndex = 13;
            label9.Click += label9_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(35, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(612, 200);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết Quả";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(416, 45);
            label13.Name = "label13";
            label13.Size = new Size(0, 15);
            label13.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(253, 160);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(167, 120);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(177, 81);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(12, 391);
            button4.Name = "button4";
            button4.Size = new Size(231, 23);
            button4.TabIndex = 15;
            button4.Text = "Chuyển sang bài tiếp theo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TinhToanPhucTap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 426);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "TinhToanPhucTap";
            Text = "TinhToanPhucTap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button button4;
    }
}