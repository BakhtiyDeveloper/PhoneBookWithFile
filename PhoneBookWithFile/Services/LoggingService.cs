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

        public void LogInformationMenu()
        {
            Console.WriteLine("-'1'- Add a contact");
            Console.WriteLine("-'2'- Remove a contact");
            Console.WriteLine("-'3'- Read all contact");
            Console.WriteLine("-'4'- Search all contact");
            Console.WriteLine("-'5'- Clear all contact");
            Console.WriteLine("-'6'- EXIT");
        }

        public void LogInformationTheProgress(string message)
        {
            Console.WriteLine($"\n{message} opetation completed....\n");
        }
    }
}