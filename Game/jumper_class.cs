using System;

namespace Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class jumper_class
    {
        public List<string> parachute = new List<string>{
            @"    _   ",
            @"  /___\  ",
            @"  \   /  ",
            @"   \ /   ",
            @"    O    ",
            @"   /|\   ",
            @"    |    ",
            @"   / \   ",
            };

        private TerminalService delivery = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Jumper.
        /// </summary>
        public jumper_class()
        {
            
            // TerminalService ts = new TerminalService();
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void DisplayParachute()
        {
            // DisplayParachute()
            foreach (string line in parachute){
                delivery.WriteText(line);
            }
            
        }

        // Jumper()
        public void BreakParachute()
        {
            parachute.RemoveAt(0);
        }
        // EraseParachute()
    }
}