namespace MethodTimer
{
    using System;
    using System.Diagnostics;
    using System.Threading;

    public class Timer
    {
        private Func<int> func;

        private int seconds;

        public Timer(Func<int> method, int seconds)
        {
            if (seconds <= 0)
            {
                throw new ArgumentException();
            }

            this.func = method;
            this.seconds = seconds;
        }

        public void GetStarted()
        {
            Stopwatch watch = new Stopwatch();
            while (seconds == seconds)
            {
                watch.Start();
                Thread.Sleep(seconds * 1000);
                watch.Stop();
                Console.WriteLine(func());
            }
        }
    }

}
