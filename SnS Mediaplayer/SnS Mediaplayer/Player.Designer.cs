namespace SnS_Mediaplayer
{
    partial class Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.InfoList = new System.Windows.Forms.RichTextBox();
            this.Playbutton = new System.Windows.Forms.PictureBox();
            this.BrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.TrackList = new System.Windows.Forms.RichTextBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.FileTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoList
            // 
            this.InfoList.Location = new System.Drawing.Point(12, 158);
            this.InfoList.Name = "InfoList";
            this.InfoList.ReadOnly = true;
            this.InfoList.Size = new System.Drawing.Size(654, 164);
            this.InfoList.TabIndex = 0;
            this.InfoList.Text = "";
            // 
            // Playbutton
            // 
            this.Playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Playbutton.BackgroundImage")));
            this.Playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Playbutton.Location = new System.Drawing.Point(12, 72);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(80, 80);
            this.Playbutton.TabIndex = 2;
            this.Playbutton.TabStop = false;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // TrackList
            // 
            this.TrackList.Location = new System.Drawing.Point(388, 12);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(278, 140);
            this.TrackList.TabIndex = 3;
            this.TrackList.Text = "";
            this.TrackList.WordWrap = false;
            // 
            // FileButton
            // 
            this.FileButton.Location = new System.Drawing.Point(12, 12);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(75, 23);
            this.FileButton.TabIndex = 4;
            this.FileButton.Text = "Choose file";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // FileTextbox
            // 
            this.FileTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileTextbox.Location = new System.Drawing.Point(93, 14);
            this.FileTextbox.Multiline = false;
            this.FileTextbox.Name = "FileTextbox";
            this.FileTextbox.ReadOnly = true;
            this.FileTextbox.Size = new System.Drawing.Size(288, 20);
            this.FileTextbox.TabIndex = 5;
            this.FileTextbox.Text = "No file selected";
            this.FileTextbox.WordWrap = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.FileTextbox);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.Playbutton);
            this.Controls.Add(this.InfoList);
            this.Name = "Player";
            this.Text = "S&S Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoList;
        private System.Windows.Forms.PictureBox Playbutton;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialog;
        private System.Windows.Forms.RichTextBox TrackList;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.RichTextBox FileTextbox;
    }
}

