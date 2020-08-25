using System;
using System.Drawing;
using System.Windows.Forms;

namespace BlackAndWhiteImg {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void pictureBox2_Resize(object sender, EventArgs e) {

        }

        private void btnOnpen_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image File (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if(fileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    pictureBox1.Image = new Bitmap(fileDialog.FileName);
                }
                catch {
                    MessageBox.Show("Can't open this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGrayScale_Click(object sender, EventArgs e) {
            if(pictureBox1.Image != null ) {
                Bitmap input = new Bitmap(pictureBox1.Image);
                Bitmap output = new Bitmap(input.Width, input.Height);

                for (int i = 0; i < input.Height; i++) {
                    for (int y = 0; y < input.Width; y++) {
                        uint pixel = (uint)(input.GetPixel(y,i).ToArgb());

                        float Alfa = (pixel & 0xff000000) >> 24;
                        float R = (pixel & 0x00ff0000) >> 16;
                        float G = (pixel & 0x0000ff00) >> 8;
                        float B =  (pixel & 0x000000ff);

                        R = G = B = (R + G + B) / 3.0f;

                        uint npixel = 0x000000|(uint)Alfa<<24 | ((uint)R << 16) | ((uint)G << 8) | (uint)B;

                        output.SetPixel(y,i, Color.FromArgb((int)npixel));
                    }
                }
                pictureBox2.Image = output;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if(pictureBox2 != null) {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Title = "Save image as...";
                savefile.OverwritePrompt = true;
                //savefile.CheckFileExists = true;
                savefile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|Png Image|*.png";
                if (savefile.ShowDialog() == DialogResult.OK) {
                    try {
                        pictureBox2.Image.Save(savefile.FileName);
                    }
                    catch {
                        MessageBox.Show("Can't save this file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
