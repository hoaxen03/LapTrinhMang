namespace Bai_Tap_Tuan_2
{
    partial class Lab2_Bai6
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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            txtSearch = new TextBox();
            txtReplace = new TextBox();
            txtEditor = new TextBox();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 71);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Mới";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpen_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 71);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Mở";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnOpen_Click;
            // 
            // button3
            // 
            button3.Location = new Point(259, 71);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Lưu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSave_Click;
            // 
            // button4
            // 
            button4.Location = new Point(381, 71);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Lưu như";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnSaveAs_Click;
            // 
            // button5
            // 
            button5.Location = new Point(833, 12);
            button5.Name = "button5";
            button5.Size = new Size(96, 23);
            button5.TabIndex = 4;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnSearch_Click;
            // 
            // button6
            // 
            button6.Location = new Point(833, 41);
            button6.Name = "button6";
            button6.Size = new Size(96, 23);
            button6.TabIndex = 5;
            button6.Text = "Thay thế";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnReplace_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(700, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(127, 23);
            txtSearch.TabIndex = 6;
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(700, 41);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(127, 23);
            txtReplace.TabIndex = 7;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(12, 100);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(917, 377);
            txtEditor.TabIndex = 8;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // Lab2_Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 489);
            Controls.Add(txtEditor);
            Controls.Add(txtReplace);
            Controls.Add(txtSearch);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lab2_Bai6";
            Text = "Lab2_Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private TextBox txtSearch;
        private TextBox txtReplace;
        private TextBox txtEditor;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}