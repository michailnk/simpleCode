using ParserHTML.Core;
using ParserHTML.Core.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserHTML {
    public partial class Form1 : Form {

        ParserWorker<string[]> parser;
        public Form1() {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new HabrParser());
            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2) {
            listBox1.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj) {
            MessageBox.Show("parse's done!");
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnStart_Click(object sender, EventArgs e) {
            parser.Settings = new HabrSettings((int)numericStart.Value, (int)numericEnd.Value);
            parser.Start();
        }

        private void btnAbort_Click(object sender, EventArgs e) {
            parser.Abort();
        }

    }
}
