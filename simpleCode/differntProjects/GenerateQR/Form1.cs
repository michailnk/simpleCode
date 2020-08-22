using QRCoder;
using System;
using System.Windows.Forms;

namespace GenerateQR {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pic.Image = code.GetGraphic(5);
        }
    }
}
