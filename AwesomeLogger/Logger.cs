using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeLogger
{
    public static class Logger
    {
        public static void LogInfo(string message, params object[] args)
        {
            // do some logging
            Console.WriteLine(message, args);
        }

        public static void LogException( Exception ex, string message =null,
            params object[] args)
        {
            // log the exception
            Console.WriteLine(
                $"Exception: {ex.ToString()}{Environment.NewLine}{message}",
                args);
        }
    }
}
