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
            this.PlayButton = new System.Windows.Forms.PictureBox();
            this.FileButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.PictureBox();
            this.TrackList = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBSeconds = new System.Windows.Forms.Label();
            this.LBMinutes = new System.Windows.Forms.Label();
            this.PauseButtonPulse = new System.Windows.Forms.PictureBox();
            this.StopButtonPulse = new System.Windows.Forms.PictureBox();
            this.PlayButtonPulse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButtonPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButtonPulse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButtonPulse)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoList
            // 
            this.InfoList.Location = new System.Drawing.Point(12, 152);
            this.InfoList.Name = "InfoList";
            this.InfoList.ReadOnly = true;
            this.InfoList.Size = new System.Drawing.Size(317, 170);
            this.InfoList.TabIndex = 0;
            this.InfoList.Text = "";
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.Location = new System.Drawing.Point(616, 13);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(40, 40);
            this.PlayButton.TabIndex = 2;
            this.PlayButton.TabStop = false;
            this.PlayButton.Click += new System.EventHandler(this.Playbutton_Click);
            this.PlayButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseHover);
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
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.Location = new System.Drawing.Point(570, 13);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(40, 40);
            this.PauseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseButton.TabIndex = 7;
            this.PauseButton.TabStop = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.PauseButton.MouseEnter += new System.EventHandler(this.PauseButton_MouseHover);
            // 
            // TrackList
            // 
            this.TrackList.AllowDrop = true;
            this.TrackList.Cursor = System.Windows.Forms.Cursors.Default;
            this.TrackList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.TrackList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(335, 132);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(331, 189);
            this.TrackList.TabIndex = 8;
            this.TrackList.DragDrop += new System.Windows.Forms.DragEventHandler(this.TrackList_DragDrop);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.Control;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopButton.Image = ((System.Drawing.Image)(resources.GetObject("StopButton.Image")));
            this.StopButton.Location = new System.Drawing.Point(524, 13);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(40, 40);
            this.StopButton.TabIndex = 9;
            this.StopButton.TabStop = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(335, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 21);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBSeconds
            // 
            this.LBSeconds.AutoSize = true;
            this.LBSeconds.Location = new System.Drawing.Point(490, 17);
            this.LBSeconds.Name = "LBSeconds";
            this.LBSeconds.Size = new System.Drawing.Size(13, 13);
            this.LBSeconds.TabIndex = 12;
            this.LBSeconds.Text = "0";
            // 
            // LBMinutes
            // 
            this.LBMinutes.AutoSize = true;
            this.LBMinutes.Location = new System.Drawing.Point(474, 17);
            this.LBMinutes.Name = "LBMinutes";
            this.LBMinutes.Size = new System.Drawing.Size(13, 13);
            this.LBMinutes.TabIndex = 13;
            this.LBMinutes.Text = "0";
            this.LBMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PauseButtonPulse
            // 
            this.PauseButtonPulse.Image = ((System.Drawing.Image)(resources.GetObject("PauseButtonPulse.Image")));
            this.PauseButtonPulse.Location = new System.Drawing.Point(570, 13);
            this.PauseButtonPulse.Name = "PauseButtonPulse";
            this.PauseButtonPulse.Size = new System.Drawing.Size(40, 40);
            this.PauseButtonPulse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PauseButtonPulse.TabIndex = 14;
            this.PauseButtonPulse.TabStop = false;
            this.PauseButtonPulse.Visible = false;
            this.PauseButtonPulse.Click += new System.EventHandler(this.PauseButton_Click);
            this.PauseButtonPulse.MouseLeave += new System.EventHandler(this.PauseButtonPulse_MouseLeave);
            // 
            // StopButtonPulse
            // 
            this.StopButtonPulse.Image = ((System.Drawing.Image)(resources.GetObject("StopButtonPulse.Image")));
            this.StopButtonPulse.Location = new System.Drawing.Point(524, 13);
            this.StopButtonPulse.Name = "StopButtonPulse";
            this.StopButtonPulse.Size = new System.Drawing.Size(40, 40);
            this.StopButtonPulse.TabIndex = 15;
            this.StopButtonPulse.TabStop = false;
            this.StopButtonPulse.Visible = false;
            this.StopButtonPulse.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButtonPulse.MouseLeave += new System.EventHandler(this.StopButtonPulse_MouseLeave);
            // 
            // PlayButtonPulse
            // 
            this.PlayButtonPulse.Image = ((System.Drawing.Image)(resources.GetObject("PlayButtonPulse.Image")));
            this.PlayButtonPulse.Location = new System.Drawing.Point(616, 13);
            this.PlayButtonPulse.Name = "PlayButtonPulse";
            this.PlayButtonPulse.Size = new System.Drawing.Size(40, 40);
            this.PlayButtonPulse.TabIndex = 16;
            this.PlayButtonPulse.TabStop = false;
            this.PlayButtonPulse.Visible = false;
            this.PlayButtonPulse.Click += new System.EventHandler(this.Playbutton_Click);
            this.PlayButtonPulse.MouseLeave += new System.EventHandler(this.PlayButtonPulse_MouseLeave);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.PlayButtonPulse);
            this.Controls.Add(this.StopButtonPulse);
            this.Controls.Add(this.PauseButtonPulse);
            this.Controls.Add(this.LBMinutes);
            this.Controls.Add(this.LBSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.InfoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "S&S Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButtonPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButtonPulse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButtonPulse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoList;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.PictureBox PauseButton;
        private System.Windows.Forms.ComboBox TrackList;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBSeconds;
        private System.Windows.Forms.Label LBMinutes;
        private System.Windows.Forms.PictureBox PauseButtonPulse;
        private System.Windows.Forms.PictureBox StopButtonPulse;
        private System.Windows.Forms.PictureBox PlayButtonPulse;
    }
}

