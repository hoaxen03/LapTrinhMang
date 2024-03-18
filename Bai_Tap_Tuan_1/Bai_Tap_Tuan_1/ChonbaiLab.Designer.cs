namespace Bai_Tap_Tuan_1
{
    partial class ChonbaiLab
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 37);
            label1.TabIndex = 0;
            label1.Text = "TRÌNH CHỌN BÀI LAB1";
            // 
            // button1
            // 
            button1.Location = new Point(33, 75);
            button1.Name = "button1";
            button1.Size = new Size(129, 59);
            button1.TabIndex = 1;
            button1.Text = "Lab1-Bai1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(191, 75);
            button2.Name = "button2";
            button2.Size = new Size(124, 59);
            button2.TabIndex = 2;
            button2.Text = "Lab1-Bai 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(350, 75);
            button3.Name = "button3";
            button3.Size = new Size(120, 59);
            button3.TabIndex = 3;
            button3.Text = "Lab1-Bai 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(93, 165);
            button4.Name = "button4";
            button4.Size = new Size(129, 53);
            button4.TabIndex = 4;
            button4.Text = "Lab1-Bai 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(255, 165);
            button5.Name = "button5";
            button5.Size = new Size(128, 53);
            button5.TabIndex = 5;
            button5.Text = "Lab1-Bai 5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // ChonbaiLab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 285);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "ChonbaiLab";
            Text = "ChonbaiLab";
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
    }
}