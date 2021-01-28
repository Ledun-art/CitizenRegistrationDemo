using System;

namespace CitizenRegistration
{
    public class DatabaseLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database Loglandı");
        }
    }
}