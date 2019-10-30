using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CSMS
{
    public partial class Registration : Form
    {
        string imageLocation = "";
        int count = 0;

        public Registration()
        {
            InitializeComponent();
        }

        private void uploadImage_click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                    //Console.WriteLine(imageLocation);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void clearImgae_click(object sender, EventArgs e)
        {
            //pictureBox1.InitialImage = null;

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
                imageLocation = "";
                //Console.WriteLine(imageLocation);
                
            }
        }

        private void exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pdfGenerator_click(object sender, EventArgs e)
        {
            string fileName = "Test" + count + ".pdf";

            if (File.Exists(fileName))
            {
                count++;
                fileName = "Test" + count + ".pdf";
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open(); //open document to write

                //adding img in PDF
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("3-2-toyota-logo-png-clipart.png");
                img.ScaleAbsolute(159f, 159f); //image size mention             
                doc.Add(img);

                //write some content
                Paragraph paragraph = new Paragraph("Demo Paragraph!!");
                doc.Add(paragraph); //above created text add on generated pdf

                doc.Close(); //close document
                //Console.WriteLine("yesssssssssssssss!!!!");
            }

            else
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open(); //open document to write

                //adding img in PDF
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("3-2-toyota-logo-png-clipart.png");
                doc.Add(img);

                //write some content
                Paragraph paragraph = new Paragraph("Demo Paragraph!!");
                doc.Add(paragraph); //above created text add on generated pdf

                doc.Close(); //close document
            }
            
        }

        private void cancelClick(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create account/insert data button
            
             
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //exit button work

            Application.Exit();
        }

        //work of PLACEHOLDER or FOCUS
        /*string x;
        private void focusEnter_click(object sender, EventArgs e)
        {
            
            if(textBox1.Text.Length != 0)
            {
                x = this.Text;
                textBox1.Text = "";
            }
        }

        private void focusLose_click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                textBox1.Text = x;
            }
        }*/
    }
}
