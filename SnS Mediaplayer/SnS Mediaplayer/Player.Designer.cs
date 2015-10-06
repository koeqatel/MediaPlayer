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
            this.StopButton = new System.Windows.Forms.PictureBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Random = new System.Windows.Forms.CheckBox();
            this.PlayTimer = new System.Windows.Forms.Timer(this.components);
            this.PauseTimer = new System.Windows.Forms.Timer(this.components);
            this.StopTimer = new System.Windows.Forms.Timer(this.components);
            this.TrackList = new System.Windows.Forms.ListBox();
            this.DebugLabel1 = new System.Windows.Forms.Label();
            this.DebugLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PlayButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopButton)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoList
            // 
            this.InfoList.Location = new System.Drawing.Point(12, 149);
            this.InfoList.Name = "InfoList";
            this.InfoList.ReadOnly = true;
            this.InfoList.Size = new System.Drawing.Size(317, 173);
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
            this.FileButton.TabIndex = 1;
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
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(93, 17);
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
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(607, 126);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(59, 17);
            this.Random.TabIndex = 3;
            this.Random.Text = "Shuffle";
            this.Random.UseVisualStyleBackColor = true;
            // 
            // PlayTimer
            // 
            this.PlayTimer.Interval = 1;
            this.PlayTimer.Tick += new System.EventHandler(this.PlayTimer_Tick);
            // 
            // PauseTimer
            // 
            this.PauseTimer.Interval = 1;
            this.PauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
            // 
            // StopTimer
            // 
            this.StopTimer.Interval = 1;
            this.StopTimer.Tick += new System.EventHandler(this.StopTimer_Tick);
            // 
            // TrackList
            // 
            this.TrackList.FormattingEnabled = true;
            this.TrackList.Location = new System.Drawing.Point(335, 149);
            this.TrackList.Name = "TrackList";
            this.TrackList.Size = new System.Drawing.Size(331, 173);
            this.TrackList.TabIndex = 2;
            // 
            // DebugLabel1
            // 
            this.DebugLabel1.AutoSize = true;
            this.DebugLabel1.Location = new System.Drawing.Point(12, 38);
            this.DebugLabel1.Name = "DebugLabel1";
            this.DebugLabel1.Size = new System.Drawing.Size(45, 13);
            this.DebugLabel1.TabIndex = 12;
            this.DebugLabel1.Text = "Debug1";
            this.DebugLabel1.Visible = false;
            // 
            // DebugLabel2
            // 
            this.DebugLabel2.AutoSize = true;
            this.DebugLabel2.Location = new System.Drawing.Point(12, 51);
            this.DebugLabel2.Name = "DebugLabel2";
            this.DebugLabel2.Size = new System.Drawing.Size(45, 13);
            this.DebugLabel2.TabIndex = 13;
            this.DebugLabel2.Text = "Debug2";
            this.DebugLabel2.Visible = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.DebugLabel2);
            this.Controls.Add(this.DebugLabel1);
            this.Controls.Add(this.TrackList);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StopButton);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoList;
        private System.Windows.Forms.PictureBox PlayButton;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.PictureBox PauseButton;
        private System.Windows.Forms.PictureBox StopButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox Random;
        private System.Windows.Forms.Timer PlayTimer;
        private System.Windows.Forms.Timer PauseTimer;
        private System.Windows.Forms.Timer StopTimer;
        private System.Windows.Forms.ListBox TrackList;
        private System.Windows.Forms.Label DebugLabel1;
        private System.Windows.Forms.Label DebugLabel2;
    }
}

