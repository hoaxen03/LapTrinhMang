namespace Bai_Tap_Tuan_2
{
    partial class Lab2_Bai2
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
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(54, 27);
            button1.Name = "button1";
            button1.Size = new Size(146, 27);
            button1.TabIndex = 0;
            button1.Text = "Chọn tệp tin nguồn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 27);
            button2.Name = "button2";
            button2.Size = new Size(146, 27);
            button2.TabIndex = 1;
            button2.Text = "Lưu tệp tin đích";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lab2_Bai2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 78);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab2_Bai2";
            Text = "Lab_Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}