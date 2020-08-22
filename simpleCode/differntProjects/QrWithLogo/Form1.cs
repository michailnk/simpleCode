using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.Presentation;
using ZXing.QrCode;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
namespace QrWithLogo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //BarcodeWriter barcode = new BarcodeWriter();
            //EncodingOptions encoding = new EncodingOptions() { Width = 300, Height = 300, Margin = 0, PureBarcode = false };
            //encoding.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
            ////var rend = new WriteableBitmapRenderer();
            //barcode.Renderer(txtInput, )

            BarcodeWriter writer = new BarcodeWriter {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions {
                    Width = 300,
                    Height = 300,
                    Margin = 0,
                    PureBarcode = false
                }
            };

            //var qrCodeImage = writer.Write(txtInput.Text); // BOOM!!

            //using (var stream = new MemoryStream()) {
            //    qrCodeImage.Save(stream, $"{Application.StartupPath}/logo.png");
            //    return stream.ToArray();
            }
       // }
    }
}
