using System;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LogErrorInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }

        public string LogInformationAndGetUserValue(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public void LogInformationTheProgress(string message)
        {
            Console.WriteLine($"{message} opetation completed....");
        }
    }
}