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
            this.HideSelect = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBSeconds = new System.Windows.Forms.Label();
            this.LBMinutes = new System.Windows.Forms.Label();
            this.Random = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideSelect)).BeginInit();
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
            this.PlayButton.MouseEnter += new System.EventHandler(this.PlayButton_MouseEnter);
            this.PlayButton.MouseLeave += new System.EventHandler(this.PlayButton_MouseLeave);
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
            this.PauseButton.MouseEnter += new System.EventHandler(this.PauseButton_MouseEnter);
            this.PauseButton.MouseLeave += new System.EventHandler(this.PauseButton_MouseLeave);
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
            this.StopButton.MouseEnter += new System.EventHandler(this.StopButton_MouseEnter);
            this.StopButton.MouseLeave += new System.EventHandler(this.StopButton_MouseLeave);
            // 
            // HideSelect
            // 
            this.HideSelect.BackColor = System.Drawing.SystemColors.Control;
            this.HideSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HideSelect.Location = new System.Drawing.Point(335, 132);
            this.HideSelect.Name = "HideSelect";
            this.HideSelect.Size = new System.Drawing.Size(331, 21);
            this.HideSelect.TabIndex = 10;
            this.HideSelect.TabStop = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(93, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(80, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "No file selected";
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
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(607, 109);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(59, 17);
            this.Random.TabIndex = 14;
            this.Random.Text = "Shuffle";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckStateChanged += new System.EventHandler(this.Random_CheckStateChanged);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.LBMinutes);
            this.Controls.Add(this.LBSeconds);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.HideSelect);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.FileButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.InfoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Player";
            this.Text = "SnS Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HideSelect)).EndInit();
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
        private System.Windows.Forms.PictureBox HideSelect;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBSeconds;
        private System.Windows.Forms.Label LBMinutes;
        private System.Windows.Forms.CheckBox Random;
    }
}

