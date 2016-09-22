using System;
using System.Diagnostics;

namespace P03_AdvancedMath
{
    class AdvancedmathTests
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Every time output is in milliseconds.\n" +
                     "First test is empty loop.");
            Console.Write("Milliseconds: ");
            long timingsSum = 0,
                timesTested = 12,
                testIntensity = 1000000;
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

            Console.WriteLine("Tests with float:");
            Console.WriteLine("Square root");
            Console.Write("Milliseconds: ");
            float floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = (float)Math.Sqrt(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Natural Logarithm");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = (float)Math.Log10(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Sinus");
            Console.Write("Milliseconds: ");
            floatNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    floatNumber = (float)Math.Sin(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();

            Console.WriteLine("Tests with double:");
            Console.WriteLine("Square root");
            Console.Write("Milliseconds: ");
            double doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = Math.Sqrt(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Natural Logarithm");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = Math.Log10(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Sinus");
            Console.Write("Milliseconds: ");
            doubleNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    doubleNumber = Math.Sin(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));
            Console.WriteLine();

            Console.WriteLine("Tests with decimal:");
            Console.WriteLine("Square root");
            Console.Write("Milliseconds: ");
            decimal decimalNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    decimalNumber = (decimal)Math.Sqrt(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));


            Console.WriteLine("Natural Logarithm");
            Console.Write("Milliseconds: ");
            decimalNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    decimalNumber = (decimal)Math.Log10(200);
                }

                watch.Stop();
                timingsSum += watch.ElapsedMilliseconds;
                Console.Write(watch.ElapsedMilliseconds + " ");
            }
            Console.WriteLine("\nAverage time consumed: " + (timingsSum / timesTested - averageForLoop));

            Console.WriteLine("Sinus");
            Console.Write("Milliseconds: ");
            decimalNumber = 0;
            timingsSum = 0;
            for (int test = 0; test < timesTested; test++)
            {
                var watch = Stopwatch.StartNew();

                for (int i = 0; i < testIntensity; i++)
                {
                    decimalNumber = (decimal)Math.Sin(200);
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
