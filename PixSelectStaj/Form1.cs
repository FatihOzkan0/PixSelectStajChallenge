using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using PixSelectStaj.Concrete;
using PixSelectStaj.Entities;

namespace PixSelectStaj
{
    public partial class Form1 : Form
    {
        VideoManager videoManager = new VideoManager(new EfVideoDal());
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            
        }

       public void Listele()
        {
            dataGridView1.DataSource = videoManager.GetAll();
        }
    }
}
