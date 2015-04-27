using System;


using System.Threading;
namespace TelerikDefender
{
    class MainClass
    {
        static void Main()
        {
            
            #region Game Sequence
            //resize the console 
            ConsoleHelper.SetConsoleFont(0); //Set the font size to  the smallest possible
            Console.SetBufferSize(300, 116);
            Console.SetWindowSize(300, 116);

            // intro screen
            SplashScreens.Intro();
            Console.Clear();
            
            // info screen

            // level 1 screen

            // level  1
            Game.ConstructPlayField();
            Game.CreateBubbles();
            while (!Game.gameOver && Game.Level == 1)
            {
                Game.Player.Control();
            }
            Game.Enemy.StopThrowing();
            Game.Enemy.Dispose();
            Console.Clear();
            
            //checking for gameOver
            if (Game.gameOver)
            {
                Game.GameOver();
                Thread.Sleep(7000);
                Console.Clear();
            }
            // level 2 screen
            Sounds.MainTheme.Stop();
            Sounds.LevelUpSound.Play();
            SplashScreens.SplashScreenLevel2();
            Console.Clear();


            // level 2
            Game.ConstructPlayField();
            Game.CreateButtercup();
            while (!Game.gameOver && Game.Level == 2)
            {
                Game.Player.Control();
            }
            Game.Enemy.StopThrowing();
            Game.Enemy.Dispose();
            Console.Clear();
            
            //checking
            if (Game.gameOver)
            {
                Game.GameOver();
                Thread.Sleep(7000);
                Console.Clear();
            }

            // level 3 screen
            Sounds.MainTheme.Stop();
            Sounds.LevelUpSound.Play();
            SplashScreens.SplashScreenLevel3();
            Console.Clear();
            Sounds.MainTheme.PlayLooping();

            // level 3 
            Game.ConstructPlayField();
            Game.CreateBlossom();
            while (!Game.gameOver && Game.Level == 3)
            {
                Game.Player.Control();
            }
            Game.Enemy.StopThrowing();
            Game.Enemy.Dispose();
            Console.Clear();

            //game win
            Sounds.MainTheme.Stop();
            Sounds.GameWinSound.Play();

            //game over
            if (Game.gameOver)
            {
                Game.GameOver();
                Thread.Sleep(7000);
                Console.Clear();
            }
            

            #endregion Game Sequence

            #region Reset Console Settings

            Console.SetWindowSize(80, 35);
            Console.SetBufferSize(80, 70);
            ConsoleHelper.SetConsoleFont(6);
            Console.ResetColor();
            Console.CursorVisible = true;

            #endregion
        }
        
        

        
        
    }
}
