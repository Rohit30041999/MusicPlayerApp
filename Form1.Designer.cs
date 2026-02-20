namespace MusicPlayerApp
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
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lstTracks = new System.Windows.Forms.ListBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.progressBarTrack = new System.Windows.Forms.ProgressBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.timerTrack = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(529, 391);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(637, 47);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(765, 391);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_click);
            // 
            // lstTracks
            // 
            this.lstTracks.FormattingEnabled = true;
            this.lstTracks.ItemHeight = 16;
            this.lstTracks.Location = new System.Drawing.Point(529, 130);
            this.lstTracks.Name = "lstTracks";
            this.lstTracks.Size = new System.Drawing.Size(311, 148);
            this.lstTracks.TabIndex = 5;
            this.lstTracks.SelectedIndexChanged += new System.EventHandler(this.lstTracks_SelectedIndexChanged);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(408, 197);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(880, 197);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // progressBarTrack
            // 
            this.progressBarTrack.Location = new System.Drawing.Point(529, 316);
            this.progressBarTrack.Name = "progressBarTrack";
            this.progressBarTrack.Size = new System.Drawing.Size(226, 23);
            this.progressBarTrack.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(761, 323);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 16);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "00:00 / 00:00";
            // 
            // timerTrack
            // 
            this.timerTrack.Interval = 500;
            this.timerTrack.Tick += new System.EventHandler(this.timerTrack_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 757);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.progressBarTrack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.lstTracks);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnPlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ListBox lstTracks;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ProgressBar progressBarTrack;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timerTrack;
    }
}

