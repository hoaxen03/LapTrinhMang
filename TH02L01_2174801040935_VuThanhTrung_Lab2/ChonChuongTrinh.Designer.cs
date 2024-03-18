namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class ChonChuongTrinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChonChuongTrinh));
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Cursor = Cursors.No;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(54, 25);
            label1.Name = "label1";
            label1.Size = new Size(691, 71);
            label1.TabIndex = 0;
            label1.Text = "Trình Chọn Chương Trình";
            // 
            // button1
            // 
            button1.Location = new Point(192, 132);
            button1.Name = "button1";
            button1.Size = new Size(128, 56);
            button1.TabIndex = 1;
            button1.Text = "Thử Nghiệm 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(426, 132);
            button2.Name = "button2";
            button2.Size = new Size(128, 56);
            button2.TabIndex = 2;
            button2.Text = "Thử Nghiệm 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 234);
            button3.Name = "button3";
            button3.Size = new Size(128, 56);
            button3.TabIndex = 3;
            button3.Text = "Bài 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(178, 234);
            button4.Name = "button4";
            button4.Size = new Size(128, 56);
            button4.TabIndex = 4;
            button4.Text = "Bài 2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(325, 234);
            button5.Name = "button5";
            button5.Size = new Size(128, 56);
            button5.TabIndex = 5;
            button5.Text = "Bài 3";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(473, 234);
            button6.Name = "button6";
            button6.Size = new Size(128, 56);
            button6.TabIndex = 6;
            button6.Text = "Bài 4";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(631, 234);
            button7.Name = "button7";
            button7.Size = new Size(128, 56);
            button7.TabIndex = 7;
            button7.Text = "Bài 5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ChonChuongTrinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(785, 309);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ChonChuongTrinh";
            Text = "ChonChuongTrinh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}