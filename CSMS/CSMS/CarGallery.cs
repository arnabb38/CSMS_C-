using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSMS
{
    public partial class CarGallery : Form
    {
        public CarGallery()
        {
            InitializeComponent();
        }

        private void CarGallery_Load(object sender, EventArgs e)
        {
            galleryPanel.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit buton

            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //inventory - car gallery

            galleryPanel.BringToFront();
            galleryPanel.Dock = DockStyle.Fill;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //back to HOME Form

            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
