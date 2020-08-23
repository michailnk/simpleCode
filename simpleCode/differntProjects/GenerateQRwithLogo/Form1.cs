using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace GenerateQRwithLogo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (txtInput.Text == null)
                return;
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOpt = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            encodingOpt.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            barcodeWriter.Renderer = new BitmapRenderer();
            barcodeWriter.Options = encodingOpt;
            barcodeWriter.Format = BarcodeFormat.QR_CODE;
            Bitmap bitmap = barcodeWriter.Write(txtInput.Text);
            Bitmap logo = new Bitmap($"{Application.StartupPath}/ind.png");
            Graphics g = Graphics.FromImage(bitmap);
            g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
            pictureBox1.Image = bitmap;

        }

        private void button2_Click(object sender, EventArgs e) {
            BarcodeReader barcodeReader = new BarcodeReader();
            var result = barcodeReader.Decode(new Bitmap(pictureBox1.Image));
            if (result != null)
                txtOutput.Text = result.Text;
        }
    }
}
