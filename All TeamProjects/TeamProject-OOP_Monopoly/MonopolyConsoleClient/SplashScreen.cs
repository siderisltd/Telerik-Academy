namespace MonopolyConsoleClient
{
    using System;
    using System.IO;

    public static class SplashScreen
    {
        public static void splashScreen()
        {
            StreamReader splashScreenReader = new StreamReader(@"../../../Monopoly/Files/SplashScreen.txt");
            using (splashScreenReader)
            {
                string currentLine = splashScreenReader.ReadLine();
                while (currentLine != null)
                {
                    Console.WriteLine(String.Format("      {0}", currentLine));
                    currentLine = splashScreenReader.ReadLine();
                }
            }
        }

        public static void WellcomeScreen()
        {
            Console.WriteLine("                                                                 WELLCOME TO MONOPOLY MULTIPLAYER");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static string[,] MakeDices(string location, string[,] dice)
        {
            dice = new string[5, 11];
            StreamReader splashScreenReader = new StreamReader(location);
            using (splashScreenReader)
            {
                string currentLine = splashScreenReader.ReadLine();
                int row = 0;
                while (currentLine != null)
                {
                    for (int i = 0; i < currentLine.Length; i++)
                    {
                        dice[row, i] = currentLine[i].ToString();
                    }
                    currentLine = splashScreenReader.ReadLine();
                    row++;
                }
            }
            return dice;
        }

       
    }
}