using System;

namespace CitizenRegistration
{
    public class SmsLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı");
        }
    }
}