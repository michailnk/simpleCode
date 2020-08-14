using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsing {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            label1.Text = "exchange rate privat bank\n";
        }

        private void button1_Click(object sender, EventArgs e) {
            if (richTextBox1.Text!= "")
                richTextBox1.Text = "";

            string line = "";

            using (WebClient wc = new WebClient()) {
                line = wc.DownloadString("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
                Match match = Regex.Match(line, "<exchangerate ccy=\"USD\" base_ccy=\"UAH\" buy=\"(.*?)\" sale=\"(.*?)\"/>");
                richTextBox1.Text += "US:   buy - " + match.Groups[1].Value + "  sale - " + match.Groups[2];
                match = Regex.Match(line, "<exchangerate ccy=\"EUR\" base_ccy=\"UAH\" buy=\"(.*?)\" sale=\"(.*?)\"/>");
                richTextBox1.Text += "\nEUR: buy - " + match.Groups[1].Value + "  sale - " + match.Groups[2];

                line = wc.DownloadString("https://api.myip.com");
                match = Regex.Match(line, "{\"ip\":\"(.*?)\",\"country\":\"(.*?)\",\"cc\":\"(.*?)\"}");

                richTextBox1.Text += "\n";

                richTextBox1.Text += "ip " + match.Groups[1].Value + "  " + match.Groups[2].Value + "\n\n";
                line = wc.DownloadString("http://worldtimeapi.org/api/ip");
                //"2020-08-13T15:25:55.591251+03:00",
                match = Regex.Match(line, "\"datetime\":\"(.*?)\",");
                line = match.Groups[1].Value;
                richTextBox1.Text += line.Substring(0, 10)+"\n";
                richTextBox1.Text += line.Substring(11, 8);
            }
        }
    }
}
