using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizualProg_lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butn_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap Files (*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void butn_rotate_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            if (radioButton90.Checked)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if (radioButton180.Checked)
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (radioButton270.Checked)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            pictureBox1.Image = bmp;

        }

        private void radioButton90_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton180_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton270_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonInvert_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);

                    Color inverted = Color.FromArgb(
                        255 - pixel.R,
                        255 - pixel.G,
                        255 - pixel.B
                    );

                    bmp.SetPixel(i, j, inverted); 
                }
            }

            pictureBox1.Image = bmp;
        }

        private void buttonUpside_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);

            pictureBox1.Image = bmp;
        }
    }
}
