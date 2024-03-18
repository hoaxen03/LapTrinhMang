namespace Bai_Tap_Tuan_2
{
    partial class Lab2_Bai7
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
            originalTextBox = new TextBox();
            encodedTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // originalTextBox
            // 
            originalTextBox.Location = new Point(144, 62);
            originalTextBox.Name = "originalTextBox";
            originalTextBox.Size = new Size(572, 23);
            originalTextBox.TabIndex = 0;
            // 
            // encodedTextBox
            // 
            encodedTextBox.Location = new Point(144, 92);
            encodedTextBox.Name = "encodedTextBox";
            encodedTextBox.Size = new Size(572, 23);
            encodedTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 62);
            button1.Name = "button1";
            button1.Size = new Size(126, 23);
            button1.TabIndex = 2;
            button1.Text = "Mã hóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 91);
            button2.Name = "button2";
            button2.Size = new Size(126, 23);
            button2.TabIndex = 3;
            button2.Text = "Giải mã";
            button2.UseVisualStyleBackColor = true;
            // 
            // Lab2_Bai7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 129);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(encodedTextBox);
            Controls.Add(originalTextBox);
            Name = "Lab2_Bai7";
            Text = "Lab2_Bai7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox originalTextBox;
        private TextBox encodedTextBox;
        private Button button1;
        private Button button2;
    }
}