using System;

namespace console_timer
{
    class Program
    {
        // TODO: Create a MVP Timer in the terminal and add features from there
        // Task:

        // Create a timer and have it work in the terminal when ran

        public static void Timer()
        {
            int seconds = 60;
            int minutes = 25;
            for(seconds = 60; seconds >=0; seconds--)
            {
                Console.SetCursorPosition(0,2);
                Console.Write("Generating Preview in {0}:{1}",minutes, seconds);
                System.Threading.Thread.Sleep(1000);
            }

        }
        static void Main(string[] args)
        {
            Timer();
        }
    }
}
