using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        private string filePath = "";

        // NAudio based player
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private List<string> playlist = new List<string>();
        private int currentTrackIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void playTrack(string filePath)
        {
            if(outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                audioFile.Dispose();
            }

            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);

            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            outputDevice.Play();
            // start the time as well
            timerTrack.Start();
        }

        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e) { 
            if(audioFile != null && audioFile.Position >= audioFile.Length)
            {
                this.Invoke((MethodInvoker) delegate 
                {
                    // stop the timer of the previous music
                    // before the next music plays
                    timerTrack.Stop();
                    btnNext.PerformClick();
                }
                    );
            }
        }

        private void timerTrack_Tick(object sender, EventArgs e)
        {
            if(audioFile != null)
            {
                progressBarTrack.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                progressBarTrack.Value = Math.Min(
                    (int)audioFile.CurrentTime.TotalSeconds,
                    progressBarTrack.Maximum
                    );

                lblTime.Text = $"{audioFile.CurrentTime.ToString("mm\\:ss")} / {audioFile.TotalTime.ToString("mm\\:ss")}";
            }
        }


        private void btnLoad_click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if(folderDialog.ShowDialog() == DialogResult.OK)
                {
                    playlist.Clear();
                    lstTracks.Items.Clear();

                    string[] files = Directory.GetFiles(folderDialog.SelectedPath);

                    foreach (string file in files)
                    {
                        if (file.EndsWith(".mp3") || file.EndsWith(".wav"))
                        {
                            playlist.Add(file);
                            lstTracks.Items.Add(Path.GetFileName(file));
                        }
                    }

                    if(playlist.Count > 0)
                    {
                        currentTrackIndex = 0;
                    }
                }
            }
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "WAV files (*.wav)|*.wav";

            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    filePath = ofd.FileName;
            //    soundPlayer.SoundLocation = filePath;
            //    //fileNameLbl.Text = System.IO.Path.GetFileName(filePath);
            //    fileNameLbl.Text = System.IO.Path.GetFileName(filePath);
            //}
        }

        private void btnPlay_click(object sender, EventArgs e)
        {
            if (playlist.Count > 0)
            {
                //soundPlayer.Play();
                if (currentTrackIndex < 0)
                    currentTrackIndex = 0;

                playTrack(playlist[currentTrackIndex]);
            }
            else
            {
                MessageBox.Show("Please load the music files.");
            }
        }

        private void btnPause_click(object sender, EventArgs e)
        {
            if(outputDevice != null)
            {
                if(outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Pause();
                }
                else if(outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Play();
                }
            }
        }

        private void btnStop_click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            currentTrackIndex++;

            if(currentTrackIndex >= playlist.Count)
            {
                currentTrackIndex = 0;
            }

            lstTracks.SelectedIndex = currentTrackIndex;
            playTrack(playlist[currentTrackIndex]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0) return;

            currentTrackIndex--;

            if(currentTrackIndex < 0)
            {
                currentTrackIndex = playlist.Count - 1;
            }

            lstTracks.SelectedIndex = currentTrackIndex;
            playTrack(playlist[currentTrackIndex]);
        }

        private void lstTracks_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTrackIndex = lstTracks.SelectedIndex;
        }
    }
}
