using System;

namespace SpaceShooter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (SpaceShooter game = new SpaceShooter())
            {
                game.Run();
            }
        }
    }
}

