using System;

namespace TelerikDefender
{
    class Pause
    {
        public static void pause()
        {
            Console.Clear();
            while (true)
            {
                ConsoleKeyInfo pause = Console.ReadKey();
                if (pause.Key == ConsoleKey.P)
                {
                    Game.ConstructPlayField();
                    break;
                }
            }
        }

    }
}
