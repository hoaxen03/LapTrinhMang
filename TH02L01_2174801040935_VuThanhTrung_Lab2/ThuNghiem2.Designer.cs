namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class ThuNghiem2
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
            btnWrite = new Button();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 40F);
            btnWrite.Location = new Point(116, 54);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(375, 101);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Viết nội dung";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // ThuNghiem2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 252);
            Controls.Add(btnWrite);
            Name = "ThuNghiem2";
            Text = "ThuNghiem2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnWrite;
    }
}