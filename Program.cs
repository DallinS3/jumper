using Game;
using System;

namespace Jumper
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}