namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class Lab2_Bai5
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
            FileListView = new ListView();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // FileListView
            // 
            FileListView.Location = new Point(12, 117);
            FileListView.Name = "FileListView";
            FileListView.Size = new Size(776, 375);
            FileListView.TabIndex = 0;
            FileListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 23F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(596, 42);
            label1.TabIndex = 1;
            label1.Text = "Trình Duyệt , Đọc Thông Tin Thư Mục";
            // 
            // button1
            // 
            button1.Location = new Point(636, 27);
            button1.Name = "button1";
            button1.Size = new Size(152, 75);
            button1.TabIndex = 2;
            button1.Text = "Lấy Tệp Tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BrowseButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Orchid;
            label2.Location = new Point(36, 74);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 3;
            label2.Text = "Tên Thư Mục :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.HotPink;
            label3.Location = new Point(173, 74);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 4;
            // 
            // Lab2_Bai5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(FileListView);
            Name = "Lab2_Bai5";
            Text = "Lab2_Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView FileListView;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}