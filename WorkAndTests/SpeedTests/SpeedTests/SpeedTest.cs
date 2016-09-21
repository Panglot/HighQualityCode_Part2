using System;
using System.Diagnostics;

namespace SpeedTests
{
    class SpeedTest
    {
        static void Main(string[] args)
        {
            var timesTested = 20;
            long timerSum = 0;

            for (int timesLooped = 0; timesLooped < timesTested; timesLooped++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < 1000000; i++)
                {
                    var array = new int[10];
                    for (int j = 0; j < 10; j++)
                    {
                        array[j] = j;
                    }
                    //array[0] = 0;
                    //array[1] = 1;
                    //array[2] = 2;
                    //array[3] = 3;
                    //array[4] = 4;
                    //array[5] = 5;
                    //array[6] = 6;
                    //array[7] = 7;
                    //array[8] = 8;
                    //array[9] = 9;
                }

                watch.Stop();
                timerSum += watch.ElapsedMilliseconds;
                Console.WriteLine(watch.ElapsedMilliseconds);
            }

            Console.WriteLine("Average: " + timerSum/timesTested);
        }
    }
}
