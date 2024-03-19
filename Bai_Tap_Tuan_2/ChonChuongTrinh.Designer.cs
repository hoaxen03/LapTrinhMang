namespace Bai_Tap_Tuan_2
{
    partial class ChonChuongTrinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            label1.BackColor = Color.Linen;
            label1.Font = new Font("Lemonada", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(35, 24);
            label1.Name = "label1";
            label1.Size = new Size(735, 96);
            label1.TabIndex = 0;
            label1.Text = "Trình Chọn Chương Trình";
            // 
            // button1
            // 
            button1.Location = new Point(17, 162);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 1;
            button1.Text = "Bài 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 162);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 2;
            button2.Text = "Bài 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(243, 162);
            button3.Name = "button3";
            button3.Size = new Size(75, 50);
            button3.TabIndex = 3;
            button3.Text = "Bài 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(356, 162);
            button4.Name = "button4";
            button4.Size = new Size(75, 50);
            button4.TabIndex = 4;
            button4.Text = "Bài 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(469, 162);
            button5.Name = "button5";
            button5.Size = new Size(75, 50);
            button5.TabIndex = 5;
            button5.Text = "Bài 6";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(582, 162);
            button6.Name = "button6";
            button6.Size = new Size(75, 50);
            button6.TabIndex = 6;
            button6.Text = "Bài 7";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(695, 162);
            button7.Name = "button7";
            button7.Size = new Size(75, 50);
            button7.TabIndex = 7;
            button7.Text = "Bài 8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ChonChuongTrinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 255);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ChonChuongTrinh";
            Text = "Chọn chương trình";
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
