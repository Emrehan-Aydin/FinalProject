using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ccs
{
    public class FileLogger : ILogger
    {
        public void log()
        {
            Console.WriteLine("Virüs yüklendi!");
        }
    }
}
