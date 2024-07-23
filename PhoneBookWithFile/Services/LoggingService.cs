using System;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}