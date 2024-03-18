namespace Bai_Tap_Tuan_1
{
    partial class DocSoTieuHoc
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
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(460, 33);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 0;
            button1.Text = "Bắt đầu đọc";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 62);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(437, 244);
            button3.Name = "button3";
            button3.Size = new Size(144, 23);
            button3.TabIndex = 2;
            button3.Text = "Thoát chương trinh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(46, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 23);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 62);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 5;
            label1.Text = "Nhập số nguyên từ 1 đến 9 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 189);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Kết Quả";
            // 
            // button4
            // 
            button4.Location = new Point(84, 244);
            button4.Name = "button4";
            button4.Size = new Size(211, 23);
            button4.TabIndex = 7;
            button4.Text = "Chuyển sang chương trình tiếp theo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DocSoTieuHoc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 279);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "DocSoTieuHoc";
            Text = "DocSoTieuHoc";
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
        private Button button4;
    }
}