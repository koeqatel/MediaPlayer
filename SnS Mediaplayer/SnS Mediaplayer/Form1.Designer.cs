namespace SnS_Mediaplayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MusicList = new System.Windows.Forms.RichTextBox();
            this.Playbutton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicList
            // 
            this.MusicList.Location = new System.Drawing.Point(12, 158);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(654, 164);
            this.MusicList.TabIndex = 0;
            this.MusicList.Text = "";
            // 
            // Playbutton
            // 
            this.Playbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Playbutton.BackgroundImage")));
            this.Playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Playbutton.Location = new System.Drawing.Point(12, 12);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(80, 80);
            this.Playbutton.TabIndex = 2;
            this.Playbutton.TabStop = false;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 334);
            this.Controls.Add(this.Playbutton);
            this.Controls.Add(this.MusicList);
            this.Name = "Form1";
            this.Text = "S&S Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.Playbutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MusicList;
        private System.Windows.Forms.PictureBox Playbutton;
    }
}

