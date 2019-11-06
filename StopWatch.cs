using System;

namespace StopWatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            while (true)
            {

                stopwatch.Start();

                Console.Write("Press Enter to stop the stopwatch.");
                Console.ReadLine();


                stopwatch.Stop();
            }

        }

        public class StopWatch
        {

            private DateTime dateTime;
            private bool isRunning = false;
            private TimeSpan timeSpan;

            public void Start()
            {

                if (!isRunning)
                {
                    dateTime = DateTime.Now;
                    isRunning = true;
                }
                else
                {
                    //throw an exception
                    Console.WriteLine("Exception Thrown.");
                }

            }

            public void Stop()
            {
                if (isRunning)
                {
                    timeSpan = DateTime.Now - dateTime;
                    isRunning = false;
                    Console.WriteLine("Duration is " + timeSpan);
                }

            }

        }

    }
}
