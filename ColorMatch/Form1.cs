using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMatch
{
    public partial class Form1 : Form
    {
        private Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            game.GuessRed = trackBarRed.Value;
            UpdateGuessPictureBox();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            game.GuessGreen = trackBarGreen.Value;
            UpdateGuessPictureBox();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            game.GuessBlue = trackBarBlue.Value;
            UpdateGuessPictureBox();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int distance = ColorHelper.Distance(game.TargetColor, game.Guess);

            MessageBox.Show($"Score: {distance}");

            StartNewGame();
        }

        public void StartNewGame()
        {
            game = new Game();
            pictureBoxColor.BackColor = game.TargetColor;

            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;

            pictureBoxGuess.BackColor = game.Guess;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        private void UpdateGuessPictureBox()
        {
            pictureBoxGuess.BackColor = game.Guess;
            pictureBoxGuess.Invalidate();
        }
    }
}
