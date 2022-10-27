// DIRECTOR

using System;
using System.Collections.Generic;
using Jumper;

// using Game.Word;

namespace Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        // private Hider _hider = new Hider();
        // private bool _isPlaying = true;
        // private Seeker _seeker = new Seeker();
        // private TerminalService _terminalService = new TerminalService();
        public bool _isPlaying = true;
        // private TerminalService

        private Word word = new Word();
        private TerminalService delivery = new TerminalService();
        private jumper_class jumper = new jumper_class();
        private string guess = "";

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            delivery.WriteLines("\nWelcome to the Jumper Game!\n");
            // TerminalService ts = new TerminalService();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                guess = GetInputs();
                DoUpdates(guess);
                DoOutputs();
            }
        }
        public string GetInputs()
        {
            // Console.WriteLine("Get inputs function");

            // letter from player
            // store string

            string letter = delivery.ReadText("\nWhat letter do you guess?\nGUESS: ");
            return letter;
        }
        private void DoUpdates(string guess)
        {
            // Console.WriteLine("DO updates function");
            // string chosenWord = Word.randomWord;

            // fill in guessed letters OR remove line from paracute
            // erase()
            bool checkValid = true;
            checkValid = word.addGuess(guess);
            if (!checkValid)
            {
                jumper.BreakParachute();
            }
        }
        private void DoOutputs()
        {
            // Console.WriteLine("Do Outputs function");
            // _isPlaying = false;

            // displayParachute()
            // gameOver()
            
            if (jumper.parachute.Count == 3)
            {
                _isPlaying = false;
                delivery.WriteText("\nThe Jumper died. You lose.\n");
                // delivery.WriteText($"{word.displayNewWord}");
            }
            else if ( word.isFound())
            {
                _isPlaying = false;
                delivery.WriteText("\nCongratulations! You guessed the word correctly and brought the Jumper down safe and sound.\n");
                // delivery.WriteText($"\n{word.displayNewWord}\n");
            }
            else{
                word.Draw();
                // jumper.DisplayParachute();
            }
            jumper.DisplayParachute();
        }
    }
}