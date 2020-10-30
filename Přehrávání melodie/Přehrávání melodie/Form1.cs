using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Přehrávání_melodie
{
    public partial class Form1 : Form
    {        
        string location = null;
        SoundPlayer player = new SoundPlayer();        
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (location != null)
            {
                player.SoundLocation = location;
                player.Play();               
                MessageBox.Show("Přehrává se melodie " + player.SoundLocation);
            }
            else
                MessageBox.Show("Vyberte soubor!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (location != null)
            {
                player.SoundLocation = location;
                player.PlaySync();
                MessageBox.Show("Přehrála se melodie " + player.SoundLocation);
            }
            else
                MessageBox.Show("Vyberte soubor!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (location != null)
            {
                player.SoundLocation = location;
                player.PlayLooping();
                MessageBox.Show("Přehrává se melodie " + player.SoundLocation);
            }   
            else
                MessageBox.Show("Vyberte soubor!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            player.Stop();
            MessageBox.Show("Přehrávání zastaveno");
        }

        private void btn_filedialog_Click(object sender, EventArgs e)
        {
            //pro vyhledání souboru použiju openfiledialog
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                //filtr všech video a audio formátů pro jednodušší vyhledávání
                ofd.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";                
                //otevře se dialog
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    location = ofd.FileName;
                    textBox1.Text = ofd.FileName;
                }
            }
        }
    }
}
