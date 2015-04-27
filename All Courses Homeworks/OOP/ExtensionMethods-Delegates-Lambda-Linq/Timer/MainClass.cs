//Problem 7. Timer
//Using delegates write a class Timer that can execute certain method at each t seconds.

namespace Timer
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Threading;
    using System.Text;

    public class MainClass
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.OutputEncoding = Encoding.Unicode;
            bool IsCalled = false;
            while (true)
            {
                TimerAndDelegate some = new TimerAndDelegate();
                //Console.WriteLine(some.Seconds);
                some = new TimerAndDelegate();

                SimpleDelegate something = new SimpleDelegate(TimerAndDelegate.Test);
                SimpleDelegate getJoke = new SimpleDelegate(JokesDataBase.GetRandomJoke);
                if (some.Seconds == 30 && IsCalled == false)
                {
                    something.DynamicInvoke();
                    getJoke.DynamicInvoke();
                    Console.WriteLine();
                    IsCalled = true;
                }
                if (some.Seconds == 31)
                {
                    IsCalled = false;
                }
            }
        }
    }
}