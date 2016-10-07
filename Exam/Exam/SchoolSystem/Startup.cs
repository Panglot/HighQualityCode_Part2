namespace SchoolSystem
{
    using System.Globalization;
    using System.Threading;
    using Core;

    internal class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
            var engine = new Engine();
            engine.Run();
        }
    }
}
