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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            timer1.Start();
        }

        private int imageNumber = 1;

        private void slideImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1;
            }

            slidePictureBox.ImageLocation = string.Format(@"Image\{0}.jpg", imageNumber);
            imageNumber++;
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //for sliding imgae

            slideImage();
        }

        private void login_click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
            //this.Enabled = false;
        }

        private void register_click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();
        }

        private void fbButton_click(object sender, EventArgs e)
        {
            //reffer to facebook
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void gmailButton_click(object sender, EventArgs e)
        {
            //reffer to gmail
            System.Diagnostics.Process.Start("https://mail.google.com");
        }

        private void twitterButton_click(object sender, EventArgs e)
        {
            //reffer to twitter
            System.Diagnostics.Process.Start("https://twitter.com");
        }

        private void carGalleryClick(object sender, EventArgs e)
        {
            CarGallery cg = new CarGallery();
            cg.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //exit button

            Application.Exit();
        }
    }
}
