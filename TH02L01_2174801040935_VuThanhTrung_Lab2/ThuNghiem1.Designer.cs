namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class ThuNghiem1
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
            btnRead = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 30F);
            btnRead.Location = new Point(114, 50);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(321, 125);
            btnRead.TabIndex = 0;
            btnRead.Text = "Nút đọc tập tin";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // ThuNghiem1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 218);
            Controls.Add(btnRead);
            Name = "ThuNghiem1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
    }
}
