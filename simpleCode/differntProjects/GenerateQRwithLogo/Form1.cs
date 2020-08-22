using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
//using ZXing.Presentation;
//using ZXing.QrCode;
//using ZXing.QrCode.Internal;
using ZXing.Rendering;

namespace GenerateQRwithLogo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            EncodingOptions encodingOpt = new EncodingOptions() { Width = 280, Height = 280, Margin = 0, PureBarcode = false };
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
