using System;

namespace TelerikDefender
{
    class SplashScreens
    {
        public static void Intro()
        {
            GameObject introScreen = new GameObject("introScreen.txt",1,1);
            introScreen.Draw();
            Console.ReadKey();
        }
        public static void Info()
        {
            GameObject infoScreen = new GameObject("infoScreen.txt", 1, 1);
            var key = Console.ReadKey();
        }
        public static void SplashScreenLevel1()
        {
            GameObject ScreenLevel1 = new GameObject("ScreenLevel1.txt", 1, 1);
            ScreenLevel1.Draw();
            var key = Console.ReadKey();
        }
        public static void SplashScreenLevel2()
        {
            GameObject ScreenLevel2 = new GameObject("ScreenLevel2.txt", 1, 1);
            ScreenLevel2.Draw();
            var key = Console.ReadKey();
        }
        public static void SplashScreenLevel3()
        {
            GameObject ScreenLevel3 = new GameObject("ScreenLevel3.txt", 1, 1);
            ScreenLevel3.Draw();
            var key = Console.ReadKey();
        }
        public static void GameWin()
        {
            GameObject Win = new GameObject("Win.txt", 1, 1);
            Win.Draw();
            var key = Console.ReadKey();
        }
        public static void GameLose()
        {
            GameObject Lose = new GameObject("Lose.txt", 1, 1);
            Lose.Draw();
            var key = Console.ReadKey();
        }
    }
}
        