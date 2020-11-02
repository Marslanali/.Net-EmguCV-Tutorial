using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;


namespace EmguCVTutorial2
{
    public partial class Form1 : Form
    {

        Image<Bgr, byte> _InputImage;
        Image<Gray, byte> _GrayImage;


        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    Image<Bgr, byte> imgInput = new Image<Bgr, byte>(ofd.FileName);
                    pictureBox1.Image = imgInput.Bitmap;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FileName = "D:\\Test.jpg";
            _InputImage = new Image<Bgr, byte>(FileName);


            if (_InputImage == null)
            {
                MessageBox.Show("Unable to Load an Image");
                return;
            }

            imageBox1.Image = _InputImage;
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Everything;

         }

        private void button2_Click(object sender, EventArgs e)
        {
            _GrayImage = _InputImage.Convert<Gray, byte>();
            panAndZoomPictureBox1.Image = _GrayImage.Bitmap;
        }
    }
}
