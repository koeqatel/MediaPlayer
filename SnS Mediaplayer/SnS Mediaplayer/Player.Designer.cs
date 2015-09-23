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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.InfoList = new System.Windows.Forms.RichTextBox();
            this.Playbutton = new System.Windows.Forms.PictureBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.PictureBox();
            this.TrackList = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.SystemColors.Control;
            this.PauseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseButton.BackgroundImage")));
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PauseButton.Location = new System.Drawing.Point(98, 72);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(80, 80);
            this.PauseButton.TabIndex = 7;
            this.PauseButton.TabStop = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // TrackList
            // 
            this.TrackList.AllowDrop = true;
            this.TrackList.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrackList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.TrackList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(545, -14);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(121, 163);
            this.TrackList.TabIndex = 8;
            this.TrackList.DragDrop += new System.Windows.Forms.DragEventHandler(this.TrackList_DragDrop);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.Control;
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StopButton.Location = new System.Drawing.Point(184, 72);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(80, 80);
            this.StopButton.TabIndex = 9;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(489, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 21);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.Playbutton);
            this.Controls.Add(this.InfoList);
            this.Name = "Player";
            this.Text = "S&S Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoList;
        private System.Windows.Forms.PictureBox Playbutton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.PictureBox PauseButton;
        private System.Windows.Forms.ComboBox TrackList;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

