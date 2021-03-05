using System;

namespace Business.ccs
{
    public class DatabaseLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Db has been logged");
        }
    }
}
