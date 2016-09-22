using System;
using System.Diagnostics;

namespace P02_SimpleMath
{
    class SimpleMathTests
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Every time output is in milliseconds.\n" +
                    "First test is empty loop.");
            Console.Write("Milliseconds: ");
            long timingsSum = 0,
                timesTested = 15,
                testIntensity = 10000000;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }

            var averageForLoop = timingsSum / timesTested;
            Console.WriteLine("\nAverage time consumed: " + averageForLoop);
            Console.WriteLine("The loop average is the base.\nIt will be subtracted from the coming tests.");
            Console.WriteLine("----------------------------------------------------------\n");

            Console.WriteLine("Tests with int:");
            Console.WriteLine("Addition");
            Console.Write("Milliseconds: ");
            int intNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    intNumber = 100000 + 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Subtraction");
            Console.Write("Milliseconds: ");
            intNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    intNumber = 100000 - 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Multiplication");
            Console.Write("Milliseconds: ");
            intNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    intNumber = 100000 * 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Division");
            Console.Write("Milliseconds: ");
            intNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    intNumber = 100000 / 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Incrementation");
            Console.Write("Milliseconds: ");
            intNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    intNumber++;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();

            Console.WriteLine("Tests with long:");
            Console.WriteLine("Addition");
            Console.Write("Milliseconds: ");
            long longNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    longNumber = 100000 + 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Subtraction");
            Console.Write("Milliseconds: ");
            longNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    longNumber = 100000 - 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Multiplication");
            Console.Write("Milliseconds: ");
            longNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    longNumber = 100000 * 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Division");
            Console.Write("Milliseconds: ");
            longNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    longNumber = 100000 / 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Incrementation");
            Console.Write("Milliseconds: ");
            longNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    longNumber++;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();


            Console.WriteLine("Tests with float:");
            Console.WriteLine("Addition");
            Console.Write("Milliseconds: ");
            float floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = 100000 + 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Subtraction");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = 100000 - 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Multiplication");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = 100000 * 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Division");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = 100000 / 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Incrementation");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber++;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();

            Console.WriteLine("Tests with double:");
            Console.WriteLine("Addition");
            Console.Write("Milliseconds: ");
            double doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 + 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Subtraction");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 - 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Multiplication");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 * 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Division");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 / 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Incrementation");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber++;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();

            Console.WriteLine("Tests with decimal:");
            Console.WriteLine("Addition");
            Console.Write("Milliseconds: ");
            decimal decimalNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 + 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Subtraction");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 - 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Multiplication");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 * 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Division");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = 100000 / 10000;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Incrementation");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber++;
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();
        }
    }
}
