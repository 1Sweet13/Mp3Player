using Mp3_player.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace Mp3_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Vars.Files.Add(openFileDialog1.FileName);// Добавить файл в плейлист
            Playlist.Items.Add(Vars.GetFileName(openFileDialog1.FileName)); 
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((Playlist.Items.Count != 0) && (Playlist.SelectedIndex != -1))
            {
                string current = Vars.Files[Playlist.SelectedIndex];
                BassLike.Play(current, BassLike.Volume);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                SLtime.Maximum = BassLike.GetTimeOfStream(BassLike.Stream);
                SLtime.Value = BassLike.GetPosOfStream(BassLike.Stream);
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            SLtime.Value = BassLike.GetPosOfStream(BassLike.Stream);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            SLtime.Value = 0;
            label1.Text = "00:00:00";   

        }

        private void SLtime_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetPoseOfScroll(BassLike.Stream,SLtime.Value);
        }

        private void SLvolume_Scroll(object sender, ScrollEventArgs e)
        {
            BassLike.SetVolumeToStream(BassLike.Stream, SLvolume.Value);
        }
    }
}
