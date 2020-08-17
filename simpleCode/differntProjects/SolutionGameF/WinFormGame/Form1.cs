using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardF;
namespace WinFormGame {
    public partial class Form1 : Form {
        Game game;
        const int SIZE = 4;
        public Form1() {
            InitializeComponent();
            game = new Game(SIZE);
            HideButtons();
        }

        private void b00_Click(object sender, EventArgs e) {
            if (game.IsSolved())
                return;
            Button button = (Button)sender; //b00
            int x = int.Parse(button.Name.Substring(1, 1));
            int y = int.Parse(button.Name.Substring(2, 1));
            game.PressAt(x, y);
            ShowButtons();
            if (game.IsSolved())
                labelMoves.Text = "Game finished in " + game.moves + " moves";
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            game.Start(1000 + DateTime.Now.DayOfYear);
            ShowButtons();
        }

        private void ShowButtons() {
            for (int x = 0; x < SIZE; x++) {
                for (int y = 0; y < SIZE; y++) {
                    ShowDigitAt(game.GetDigitAt(x, y), x, y);
                } 
            }
            labelMoves.Text = game.moves + " moves";
        }

        private void ShowDigitAt(int digit, int x, int y) {
            Button button = (Button)Controls["b" + x + y];
            button.Text = digit.ToString("X"); //digit.ToString();
            button.Visible = digit > 0; 

        }

        private void HideButtons() {
            for (int x = 0; x < SIZE; x++) {
                for (int y = 0; y < SIZE; y++) {
                    ShowDigitAt(0, x, y);
                }
            }
        labelMoves.Text= game.moves + " moves";
        }
    }
}
