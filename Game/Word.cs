// using Random;
using System.IO;

namespace Game
{
    public class Word
    {
        string randomWord = "";
        string logPath = "D:\\user_DallinS\\Computer Folders\\School Stuff\\byu-i_3fall2022\\b2_cse210-02_program-with-classes_phillips\\Jumper\\Game\\new_file.txt";
        private List<string> guesses = new List<string>();
        public bool isGuessed = false;
        private List<string> getWord = new List<string>();
        private TerminalService delivery = new TerminalService();

        public Word()
        {
            List<string> wordList = new List<string> { "about", "apricot", "apple", "ate", "eight", "infinity", "duodecillion", "numerical", "fruit", "antidisestablishmentarianism", "pneumonoultramicroscopicsolicovolcaniconiosis", "floxinoxinihilipilification", "quinquinquagintillion", "superb", "umbrella", "fantasmagorical", "stupendous", "dog", "cat", "mouse", "horse", "ham", "sandwich", "chips", "crisps", "boot", "sock", "dire" };

            // Figure out how to read "new_file" from C#
            List<string> newFileWordList = File.ReadAllLines(logPath).ToList();

            Console.WriteLine(newFileWordList[1]);

            // string chosenWord = newWord(wordList);

            string randomWord = newWord(wordList);
            for (int i = 0; i < randomWord.Length; i++)
            {
                char letter = randomWord.ElementAt(i);
                string newLetter = letter.ToString();
                getWord.Add(newLetter);
            }
        }

    // I could use some help here
        public string newWord(List<string> wordList)
        {
            Random listIndex = new Random();
            int lastWord = wordList.Count;
            // listIndex = Convert.Toint(listIndex)
            randomWord = wordList.ElementAt(listIndex.Next(0, lastWord));

            Console.WriteLine(randomWord);
            return randomWord;
        }

        public bool addGuess(string guess)
        {
            guesses.Add(guess);
            return getWord.Contains(guess);
        }
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
        public void Draw()
        {
            foreach (string letter in getWord)
            {
                if (guesses.Contains(letter))
                {
                    delivery.WriteText($"{letter}");
                }
                else
                {
                    delivery.WriteLines(" _ ");
                }
            }
        }
    }
        // List<string> wordList = new List<string> { "about", "apricot", "apple", "ate", "eight", "infinity", "duodecillion", "numerical", "fruit", "antidisestablishmentarianism", "pneumonoultramicroscopicsolicovolcaniconiosis", "floxinoxinihilipilification", "quinquinquagintillion", "superb", "umbrella", "fantasmagorical", "stupendous", "dog", "cat", "mouse", "horse", "ham", "sandwich", "chips", "crisps", "boot", "sock", "dire" };
        
        /*
            {
            List<string> gitHubWords = new List<string> {}
            }
        */
}