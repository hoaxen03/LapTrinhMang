﻿namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class Lab2_Bai1
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
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(30, 41);
            button1.Name = "button1";
            button1.Size = new Size(200, 101);
            button1.TabIndex = 0;
            button1.Text = "Đọc Tệp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRead_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(30, 167);
            button2.Name = "button2";
            button2.Size = new Size(200, 101);
            button2.TabIndex = 1;
            button2.Text = "Ghi Tệp";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(281, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(444, 232);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // Lab2_Bai1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 285);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab2_Bai1";
            Text = "Lab2_Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}