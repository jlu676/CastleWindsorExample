using System;

namespace CastleWindsorExample.CommonDependencies
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

}