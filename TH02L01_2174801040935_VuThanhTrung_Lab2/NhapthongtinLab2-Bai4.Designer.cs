namespace TH02L01_2174801040935_VuThanhTrung_Lab2
{
    partial class NhapthongtinLab2_Bai4
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
            txtMSSV = new TextBox();
            txtHoTen = new TextBox();
            txtDienThoai = new TextBox();
            txtDiemToan = new TextBox();
            txtDiemVan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(648, 75);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = "Nhập học viên";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnOK_Click;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(221, 76);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(400, 23);
            txtMSSV.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(221, 140);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 23);
            txtHoTen.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(221, 204);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(400, 23);
            txtDienThoai.TabIndex = 3;
            // 
            // txtDiemToan
            // 
            txtDiemToan.Location = new Point(221, 268);
            txtDiemToan.Name = "txtDiemToan";
            txtDiemToan.Size = new Size(400, 23);
            txtDiemToan.TabIndex = 4;
            // 
            // txtDiemVan
            // 
            txtDiemVan.Location = new Point(221, 332);
            txtDiemVan.Name = "txtDiemVan";
            txtDiemVan.Size = new Size(400, 23);
            txtDiemVan.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 79);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 143);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 7;
            label2.Text = "Họ và tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 207);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 271);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 9;
            label4.Text = "Điểm toán ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 335);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Điểm văn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Magenta;
            label6.Location = new Point(174, 9);
            label6.Name = "label6";
            label6.Size = new Size(524, 54);
            label6.TabIndex = 11;
            label6.Text = "Nhập Thông Tin Học Viên";
            // 
            // NhapthongtinLab2_Bai4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiemVan);
            Controls.Add(txtDiemToan);
            Controls.Add(txtDienThoai);
            Controls.Add(txtHoTen);
            Controls.Add(txtMSSV);
            Controls.Add(button1);
            Name = "NhapthongtinLab2_Bai4";
            Text = "NhapthongtinLab2_Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtMSSV;
        private TextBox txtHoTen;
        private TextBox txtDienThoai;
        private TextBox txtDiemToan;
        private TextBox txtDiemVan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}