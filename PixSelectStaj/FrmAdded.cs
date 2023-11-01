using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using PixSelectStaj.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixSelectStaj
{
    public partial class FrmAdded : Form
    {
        VideoManager videoManager = new VideoManager(new EfVideoDal());
        public FrmAdded()
        {
            InitializeComponent();
        }

        private void btnAdded_Click(object sender, EventArgs e)
        {
            string videoTitle = txtTitle.Text;
            string videoPath = txtPath.Text;

            if(string.IsNullOrEmpty(videoTitle) || string.IsNullOrEmpty(videoPath))
            {
                MessageBox.Show("Boş Alan Geçilemez");
            }
            else
            {
                videoManager.Add(new Video
                {
                    VideoTitle = videoTitle,
                    VideoPath = videoPath
                });


                MessageBox.Show("Video Eklendi");
                HomePage frm2 = new HomePage();
                frm2.Show();
                this.Hide();
            }
          
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage form2 = new HomePage();
            form2.Show();
            this.Hide();
        }

        private void FrmAdded_Load(object sender, EventArgs e)
        {

        }
    }
}
