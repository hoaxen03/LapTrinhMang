namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class Lab2_Bai4
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
            listBoxHocVien = new ListBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(595, 149);
            button1.Name = "button1";
            button1.Size = new Size(147, 60);
            button1.TabIndex = 0;
            button1.Text = "Lưu thông tin học viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnXuatFile_Click;
            // 
            // button2
            // 
            button2.Location = new Point(595, 313);
            button2.Name = "button2";
            button2.Size = new Size(147, 60);
            button2.TabIndex = 1;
            button2.Text = "Xem thông tin học viên ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnDocFile_Click;
            // 
            // button3
            // 
            button3.Location = new Point(595, 231);
            button3.Name = "button3";
            button3.Size = new Size(147, 60);
            button3.TabIndex = 2;
            button3.Text = "Tính điểm trung bình";
            button3.UseVisualStyleBackColor = true;
            // 
            // listBoxHocVien
            // 
            listBoxHocVien.AccessibleName = "";
            listBoxHocVien.FormattingEnabled = true;
            listBoxHocVien.ItemHeight = 15;
            listBoxHocVien.Location = new Point(30, 65);
            listBoxHocVien.Name = "listBoxHocVien";
            listBoxHocVien.Size = new Size(528, 319);
            listBoxHocVien.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(595, 67);
            button4.Name = "button4";
            button4.Size = new Size(147, 60);
            button4.TabIndex = 4;
            button4.Text = "Nhập thông tin học viên";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNhap_Click;
            // 
            // Lab2_Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(button4);
            Controls.Add(listBoxHocVien);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab2_Bai4";
            Text = "Lab2_Bai4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBoxHocVien;
        private Button button4;
    }
}