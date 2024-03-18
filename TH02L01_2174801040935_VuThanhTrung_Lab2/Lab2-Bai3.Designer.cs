namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class Lab2_Bai3
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
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(291, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(395, 162);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(24, 12);
            button1.Name = "button1";
            button1.Size = new Size(261, 68);
            button1.TabIndex = 1;
            button1.Text = "Đọc tệp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRead_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 25F);
            button2.Location = new Point(24, 152);
            button2.Name = "button2";
            button2.Size = new Size(261, 73);
            button2.TabIndex = 2;
            button2.Text = "Tính và lưu tệp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 30F);
            button3.Location = new Point(24, 86);
            button3.Name = "button3";
            button3.Size = new Size(261, 60);
            button3.TabIndex = 3;
            button3.Text = "Tính";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCalculate_Click;
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 237);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Name = "Lab2_Bai3";
            Text = "Lab2_Bai3";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}