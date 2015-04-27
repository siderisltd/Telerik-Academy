namespace Timer
{
    using System;

    public delegate void SimpleDelegate();

    public class TimerAndDelegate
    {
        private int seconds = DateTime.Now.Second;

        public int Seconds
        {
            get 
            {
                return seconds; 
            }
        }

      

        public static void Test()
        {
            Console.WriteLine("[Joke of the 30's :)]");
            Console.WriteLine();
        }
    }
}
