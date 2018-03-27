using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Hangman : Form
    {

        HangmanGame Hgame = new HangmanGame();
        bool GameStarted = false;

        public Hangman()
        {
            InitializeComponent();
        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            Hgame.newGame();
            textBox_wordToGuess.Text = Hgame.hiddenWordDisplay();
            textBox_numberOfAttempts.Text = Hgame.NumberOfAttempts.ToString();
            GameStarted = true;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            btn_E.Enabled = true;
            btn_F.Enabled = true;
            btn_G.Enabled = true;
            btn_H.Enabled = true;
            btn_I.Enabled = true;
            btn_J.Enabled = true;
            btn_K.Enabled = true;
            btn_L.Enabled = true;
            btn_M.Enabled = true;
            btn_N.Enabled = true;
            btn_O.Enabled = true;
            btn_P.Enabled = true;
            btn_Q.Enabled = true;
            btn_R.Enabled = true;
            btn_S.Enabled = true;
            btn_T.Enabled = true;
            btn_U.Enabled = true;
            btn_V.Enabled = true;
            btn_W.Enabled = true;
            btn_X.Enabled = true;
            btn_Y.Enabled = true;
            btn_Z.Enabled = true;
            
        }
        


        private void btn_A_Click(object sender, EventArgs e)
        {
           
            if (GameStarted)
            {
                Button button = (Button)sender;
                button.Enabled = false;
                char letterToCheck = Convert.ToChar(button.Text);

                if (Hgame.GameOver())
                {
                    textBox_wordToGuess.Text = Hgame.WordToGuess;
                    
                    MessageBox.Show("You lost all your attempts.\nBetter luck next time. :)", "END GAME");
                    
                    btn_startGame.PerformClick();
                }
                else
                {
                    Hgame.hitLetter(letterToCheck);
                    textBox_wordToGuess.Text = Hgame.hiddenWordDisplay();
                    textBox_numberOfAttempts.Text = Hgame.NumberOfAttempts.ToString();

                }

            }

            if (Hgame.win())
            {
                MessageBox.Show("You guess the word, number of left attempts: "+Hgame.NumberOfAttempts, "CONGRATULATION");
                btn_startGame.PerformClick();
            }

        }

        private void Hangman_Load(object sender, EventArgs e)
        {

        }
    }
}
