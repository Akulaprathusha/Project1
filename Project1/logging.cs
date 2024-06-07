using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal interface Logging
    {
        void Log(String message);
    }

    public class FileLog : Logging
    {
        public void Log(String message)
        {
           Console.WriteLine($"File log:{message}");
        }
    }

    public class ConsoleLog : Logging
    {
        public void Log(String message)
        {
            Console.WriteLine($"File log:{message}");
        }
    }
}
