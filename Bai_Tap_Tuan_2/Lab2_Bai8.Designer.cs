namespace Bai_Tap_Tuan_2
{
    partial class Lab2_Bai8
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
            lstFiles = new ListBox();
            button1 = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 15;
            lstFiles.Location = new Point(150, 84);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(788, 319);
            lstFiles.TabIndex = 0;
            lstFiles.DoubleClick += lstFiles_DoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(21, 84);
            button1.Name = "button1";
            button1.Size = new Size(105, 110);
            button1.TabIndex = 1;
            button1.Text = "Mở tệp tin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpenFolder_Click;
            // 
            // Lab2_Bai8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 415);
            Controls.Add(button1);
            Controls.Add(lstFiles);
            Name = "Lab2_Bai8";
            Text = "Lab2_Bai8";
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstFiles;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog;
    }
}