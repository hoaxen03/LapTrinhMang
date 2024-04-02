namespace SocketMayKhach
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbMessage = new RichTextBox();
            groupBox1 = new GroupBox();
            tbLog = new RichTextBox();
            ccbNguoiGui = new ComboBox();
            ccbNguoiNhan = new ComboBox();
            tm = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.Text = "Gửi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 28F, FontStyle.Bold);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(294, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 51);
            label1.TabIndex = 1;
            label1.Text = "LASAZER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Người Gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Người Nhận";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(96, 125);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(692, 93);
            tbMessage.TabIndex = 4;
            tbMessage.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbLog);
            groupBox1.Location = new Point(12, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 214);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch sử tin nhắn";
            // 
            // tbLog
            // 
            tbLog.Location = new Point(6, 22);
            tbLog.Name = "tbLog";
            tbLog.Size = new Size(764, 186);
            tbLog.TabIndex = 0;
            tbLog.Text = "";
            // 
            // ccbNguoiGui
            // 
            ccbNguoiGui.FormattingEnabled = true;
            ccbNguoiGui.Items.AddRange(new object[] { "Trung", "Linh" });
            ccbNguoiGui.Location = new Point(96, 69);
            ccbNguoiGui.Name = "ccbNguoiGui";
            ccbNguoiGui.Size = new Size(686, 23);
            ccbNguoiGui.TabIndex = 6;
            // 
            // ccbNguoiNhan
            // 
            ccbNguoiNhan.FormattingEnabled = true;
            ccbNguoiNhan.Items.AddRange(new object[] { "Trung", "Linh" });
            ccbNguoiNhan.Location = new Point(96, 99);
            ccbNguoiNhan.Name = "ccbNguoiNhan";
            ccbNguoiNhan.Size = new Size(686, 23);
            ccbNguoiNhan.TabIndex = 7;
            // 
            // tm
            // 
            tm.Tick += Tm_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ccbNguoiNhan);
            Controls.Add(ccbNguoiGui);
            Controls.Add(groupBox1);
            Controls.Add(tbMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox tbMessage;
        private GroupBox groupBox1;
        private RichTextBox tbLog;
        private ComboBox ccbNguoiGui;
        private ComboBox ccbNguoiNhan;
        private System.Windows.Forms.Timer tm;
    }
}
