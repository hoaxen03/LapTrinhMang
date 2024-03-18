namespace Bai_Tap_Tuan_1
{
    partial class ChuyenDoiTienTe
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
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 0;
            label1.Text = "Chuyển Đổi Tiền Tệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 190);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Số tiền đã đổi";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(124, 104);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 3;
            button1.Text = "Chuyển đổi ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(130, 23);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 221);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "Tỉ giá quy đổi";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(129, 219);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 190);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(33, 256);
            button2.Name = "button2";
            button2.Size = new Size(185, 23);
            button2.TabIndex = 11;
            button2.Text = "Chuyển sang bài tiếp theo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(356, 256);
            button3.Name = "button3";
            button3.Size = new Size(168, 23);
            button3.TabIndex = 12;
            button3.Text = "Thoát chương trình";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ChuyenDoiTienTe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 291);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ChuyenDoiTienTe";
            Text = "ChuyenDoiTienTe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
    }
}