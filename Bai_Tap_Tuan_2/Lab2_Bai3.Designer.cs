namespace Bai_Tap_Tuan_2
{
    partial class Lab2_Bai3
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
            button5 = new Button();
            txtEditor = new RichTextBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(244, 57);
            button1.Name = "button1";
            button1.Size = new Size(126, 47);
            button1.TabIndex = 0;
            button1.Text = "Mở";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpen_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 57);
            button2.Name = "button2";
            button2.Size = new Size(126, 47);
            button2.TabIndex = 1;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // button3
            // 
            button3.Location = new Point(708, 57);
            button3.Name = "button3";
            button3.Size = new Size(126, 47);
            button3.TabIndex = 2;
            button3.Text = "Lưu như";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSaveAs_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 57);
            button5.Name = "button5";
            button5.Size = new Size(126, 47);
            button5.TabIndex = 4;
            button5.Text = "Mới";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNew_Click;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(12, 110);
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(824, 376);
            txtEditor.TabIndex = 5;
            txtEditor.Text = "";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // Lab2_Bai3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 498);
            Controls.Add(txtEditor);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab2_Bai3";
            Text = "Lab2_Bai2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private RichTextBox txtEditor;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}