using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class HangmanGame
    {

        wordsForGame words = wordsForGame.GetInstance();
        private string hiddenWord;
        int numberOfAttempts = 8;
        private string wordToGuess;
       
        public HangmanGame()
        {
            this.wordToGuess = words.getWord();
            this.hiddenWord = this.generateHiddenWord();
        }

        public string WordToGuess
        {
            get { return this.wordToGuess; }
            private set { this.wordToGuess = value; }
        }

        public int NumberOfAttempts
        {
            get { return this.numberOfAttempts; }
            private set { this.numberOfAttempts = value; }

        }

        public string HiddenWord
        {
            get { return this.hiddenWord; }
            private set { this.hiddenWord = value; }
        }

        private string generateHiddenWord()
        {
            StringBuilder builder = new StringBuilder();
            for(int i=0; i<this.wordToGuess.Count(); i++)
            {
                builder.Append("_");
            }
            return builder.ToString();
        }

        public void hitLetter(char letter)
        {
            
                if( tryHitLetter(letter))
                {
                    revealHiddenLetter(letter);
                }
                else
                {
                    numberOfAttempts--;
                }     
        }

        private bool anyAttemptLeft()
        {
            return numberOfAttempts > 0;
        }

        private bool tryHitLetter(char letter)
        {
            return wordToGuess.Contains(letter);
        }

        private void revealHiddenLetter(char letter)
        {
            char[] tempHiddenWord = HiddenWord.ToArray();

            for(int i=0; i<wordToGuess.Count(); i++)
            {
                if (wordToGuess[i].Equals(letter))
                {
                    tempHiddenWord[i] = letter;
                }
            }
            HiddenWord = new string(tempHiddenWord);
        }

        public bool GameOver()
        {
            return numberOfAttempts == 1;
        }

        public void newGame()
        {
            this.WordToGuess = words.getWord();
            this.NumberOfAttempts = 8;
            this.HiddenWord = this.generateHiddenWord();
        }

        public bool win()
        {
            return this.wordToGuess == this.hiddenWord;
        }

        public string hiddenWordDisplay()
        {
            StringBuilder builder = new StringBuilder();
            foreach (char c in hiddenWord)
            {
                builder.Append(c + " ");
            }
            return builder.ToString();
        }

    }
}
