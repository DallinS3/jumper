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
        /// <summary>
        /// Creates the parachute to be used in the program
        /// </summary>
        /// <value></value>
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
        /// Displays the parachute by writing the parachute as instantiated above
        /// </summary>
        public void DisplayParachute()
        {
            // DisplayParachute()
            foreach (string line in parachute){
                delivery.WriteText(line);
            }
            
        }

        // Jumper()
        /// <summary>
        /// Removes one line of the parachute for every wrong guess
        /// </summary>
        public void BreakParachute()
        {
            parachute.RemoveAt(0);
        }
        // EraseParachute()
    }
}