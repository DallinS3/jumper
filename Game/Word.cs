// using Random;
using System.IO;

namespace Game
{
    /// <summary>
    /// Creates a new instance of the Word class
    /// Runs as a new director
    /// </summary>
    public class Word
    {
        protected string randomWord = "";
        string logPath = "D:\\user_DallinS\\Computer Folders\\School Stuff\\byu-i_3fall2022\\b2_cse210-02_program-with-classes_phillips\\Jumper\\Game\\new_file.txt";
        private List<string> guesses = new List<string>();
        public bool isGuessed = false;
        private List<string> getWord = new List<string>();
        private TerminalService delivery = new TerminalService();

        /// <summary>
        /// Reads in all random words from the new_file.txt.
        /// Puts every new word into a list.
        /// </summary>
        public Word()
        {
            // List<string> wordList = new List<string> { "about", "apricot", "apple", "ate", "eight", "infinity", "duodecillion", "numerical", "fruit", "antidisestablishmentarianism", "pneumonoultramicroscopicsolicovolcaniconiosis", "floxinoxinihilipilification", "quinquinquagintillion", "superb", "umbrella", "fantasmagorical", "stupendous", "dog", "cat", "mouse", "horse", "ham", "sandwich", "chips", "crisps", "boot", "sock", "dire" };

            // Reads "new_file" into list
            List<string> newFileWordList = File.ReadAllLines(logPath).ToList();
            // Console.WriteLine(newFileWordList[1]);

            // string chosenWord = newWord(wordList);

            // string randomWord = newWord(wordList);
            // for (int i = 0; i < randomWord.Length; i++)
            // {
            //     char letter = randomWord.ElementAt(i);
            //     string newLetter = letter.ToString();
            //     getWord.Add(newLetter);
            // }

            string randomWord = newWord(newFileWordList);
            for (int i = 0; i < randomWord.Length; i++)
            {
                char letter = randomWord.ElementAt(i);
                string newLetter = letter.ToString();
                getWord.Add(newLetter);
            }
        }

        /// <summary>
        /// Uses the random function to pick a random word from the list.
        /// Outputs that word to use for the game.
        /// </summary>
        /// <param name="newFileWordList"></param>
        /// <returns>"randomWord"</returns>
        public string newWord(List<string> newFileWordList)
        {
            Random listIndex = new Random();
            int lastWord = newFileWordList.Count;
            // listIndex = Convert.Toint(listIndex)
            randomWord = newFileWordList.ElementAt(listIndex.Next(0, lastWord));

            // Console.WriteLine(randomWord);
            return randomWord;
        }

        // public void displayNewWord(){
        //     Console.WriteLine(randomWord);
        // }

        // public string newChosenWord(List<string> newFileWordList)
        // {
        //     Random listIndex = new Random();
        //     int lastWord = newFileWordList.Count;
        //     // listIndex = Convert.Toint(listIndex)
        //     randomWord = newFileWordList.ElementAt(listIndex.Next(0, lastWord));

        //     Console.WriteLine(randomWord);
        //     return randomWord;
        // }

        /// <summary>
        /// Adds the letter to a guesses list
        /// </summary>
        /// <param name="guess"></param>
        /// <returns></returns>
        public bool addGuess(string guess)
        {
            guesses.Add(guess);
            return getWord.Contains(guess);
        }

        /// <summary>
        /// Checks if the guessed word(s) are found in the randomWord selected.
        /// </summary>
        /// <returns></returns>
        public bool isFound()
        {
            bool isFound = true;

            foreach (string letter in getWord)
            {
                if (!guesses.Contains(letter))
                {
                    isFound = false;
                }
            }
            return isFound;
        }

        /// <summary>
        /// Outputs the right guessed letters in the terminal.
        /// The letters not yet guessed correctly are outputted as " _ "
        /// </summary>
        public void Draw()
        {
            delivery.WriteText($"\n");
            foreach (string letter in getWord)
            {
                if (guesses.Contains(letter))
                {
                    delivery.WriteLines($"{letter}");
                }
                else
                {
                    delivery.WriteLines(" _ ");
                }
            }
            delivery.WriteText($"\n");
        }
    }
        // List<string> wordList = new List<string> { "about", "apricot", "apple", "ate", "eight", "infinity", "duodecillion", "numerical", "fruit", "antidisestablishmentarianism", "pneumonoultramicroscopicsolicovolcaniconiosis", "floxinoxinihilipilification", "quinquinquagintillion", "superb", "umbrella", "fantasmagorical", "stupendous", "dog", "cat", "mouse", "horse", "ham", "sandwich", "chips", "crisps", "boot", "sock", "dire" };
        
        /*
            {
            List<string> gitHubWords = new List<string> {}
            }
        */
}