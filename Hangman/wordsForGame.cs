using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
   public class wordsForGame
    {
        private List<String> terms;
        private static wordsForGame instance;
        Random random = new Random();

        private wordsForGame()
        {
            terms = this.ListOfWords();
        }

        public static wordsForGame GetInstance()
        {
            if (instance == null)
            {
                instance = new wordsForGame();
            }
            return instance;

        }

        private string BagOfWords()
        {
            string words;
            using (System.IO.StreamReader reader= new System.IO.StreamReader("Croatian_words.txt"))
            {
                words = reader.ReadToEnd();
            }
            return words;
        }

        private List<string> ListOfWords()
        {
            char splitToken = ',';
            List<String> wordsList = new List<string>();
            String[] wordsParts = this.BagOfWords().Split(splitToken);
            foreach(String word in wordsParts)
            {
                wordsList.Add(word);
            }
            return wordsList;

        }


        public string getWord()
        {
            return terms.ElementAt(random.Next(terms.Count));
        }

    } 
}
