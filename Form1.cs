using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        private string filePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV files (*.wav)|*.wav";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                soundPlayer.SoundLocation = filePath;
                //fileNameLbl.Text = System.IO.Path.GetFileName(filePath);
                fileNameLbl.Text = System.IO.Path.GetFileName(filePath);
            }
        }

        private void btnPlay_click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                soundPlayer.Play();
            }
            else
            {
                MessageBox.Show("Please load a music file.");
            }
        }

        private void btnStop_click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }
    }
}
