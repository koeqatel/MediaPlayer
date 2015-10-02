namespace SnS_Mediaplayer
{
    partial class FileDialog
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
            this.FilesInFolder = new System.Windows.Forms.ComboBox();
            this.VisibleFolder = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // FilesInFolder
            // 
            this.FilesInFolder.BackColor = System.Drawing.SystemColors.Window;
            this.FilesInFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.FilesInFolder.FormattingEnabled = true;
            this.FilesInFolder.Location = new System.Drawing.Point(12, 47);
            this.FilesInFolder.Name = "FilesInFolder";
            this.FilesInFolder.Size = new System.Drawing.Size(559, 202);
            this.FilesInFolder.TabIndex = 0;
            this.FilesInFolder.Text = "Files";
            this.FilesInFolder.SelectionChangeCommitted += new System.EventHandler(this.FilesInFolder_SelectionChangeCommitted);
            // 
            // VisibleFolder
            // 
            this.VisibleFolder.Location = new System.Drawing.Point(93, 10);
            this.VisibleFolder.Name = "VisibleFolder";
            this.VisibleFolder.Size = new System.Drawing.Size(478, 23);
            this.VisibleFolder.TabIndex = 1;
            this.VisibleFolder.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VisibleFolder);
            this.Controls.Add(this.FilesInFolder);
            this.Name = "FileDialog";
            this.Text = "FileDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FilesInFolder;
        private System.Windows.Forms.RichTextBox VisibleFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}