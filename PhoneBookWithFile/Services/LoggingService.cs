using System;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {
        public void LoggerExcepion(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Please run again");
        }

        public void LoggerForAdd()
        {
            Console.WriteLine("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
            Console.Write("Enter name and number: ");
        }

        public void LoggerForRemove()
        {
            Console.WriteLine("Warning : write name and number format correctly to delete: (Sherzod +998918285636)");
            Console.Write("Enter name and number: ");
        }

        public void LoggerMenu()
        {
            Console.WriteLine("what do you want to do");
            Console.WriteLine("-'1'- Add a contact");
            Console.WriteLine("-'2'- Remove a contact");
            Console.WriteLine("-'3'- Show all contact");
            Console.WriteLine("-'4'- Clear Phone-Book");
            Console.WriteLine("-'5'- EXIT");
        }

        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}