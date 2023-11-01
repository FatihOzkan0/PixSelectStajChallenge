using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using PixSelectStaj.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WMPLib;

namespace PixSelectStaj
{
    public partial class HomePage : Form
    {
        VideoManager Videomanager = new VideoManager(new EfVideoDal());
        static string pathUrl = "";
        public HomePage()
        {
            InitializeComponent();


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            Listele();
        }

        public void Listele()
        {
            dgVeriler.DataSource = Videomanager.GetAll();
        }

        private void btnYükle_Click(object sender, EventArgs e)
        {
            FrmAdded frmAdded = new FrmAdded();
            frmAdded.Show();
            this.Hide();
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = pathUrl;
            
            
           



        }

        private void dgVeriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pathUrl = dgVeriler.CurrentRow.Cells[2].Value.ToString();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -=10;
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
        }

        private void comboSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSpeed = comboSpeed.SelectedItem.ToString();

            switch (selectSpeed)
            {
                case "1x":
                    axWindowsMediaPlayer1.settings.rate = 1.0;
                    break;
                case "2x":
                    axWindowsMediaPlayer1.settings.rate =  2.0;
                    break;
               

            }

        }

        private void VideoBar_Click(object sender, EventArgs e)
        {
           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            TimeSpan currentTime = TimeSpan.FromMilliseconds(axWindowsMediaPlayer1.Ctlcontrols.currentPosition * 1000);
            lblTimes.Text = currentTime.ToString(@"hh\:mm\:ss");

            
            VideoBar.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            VideoBar.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

          
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
               
                timer1.Start();
            }
            else
            {
                
                timer1.Stop();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        

        private void buttonPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
