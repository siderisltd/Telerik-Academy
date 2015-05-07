namespace Monopoly
{
    using System;

    class MainClass
    {
        static void Main()
        {
            #region Console and font resizing
            //resize the console 
            ConsoleHelper.SetConsoleFont(8); //Set the font size to  the smallest possible
            Console.WindowHeight = Console.LargestWindowHeight - 1;
            Console.WindowWidth = Console.LargestWindowWidth - 4;
            ConsoleUtils.CenterConsole();
            #endregion Console and font resizing
        }
    }
}
