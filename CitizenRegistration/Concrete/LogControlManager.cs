namespace CitizenRegistration
{
    internal class LogControlService
    {
        public void Database()
        {
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log();
        }

        public void Sms()
        {
            SmsLogger smsLogger = new SmsLogger();
            smsLogger.Log();
        }
    }
}