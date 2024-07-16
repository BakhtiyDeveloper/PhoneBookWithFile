using System;

namespace PhoneBookWithFile.Services
{
    internal class LoggingService : ILoggingService
    {

        public void LoggerMenu()
        {
            Console.WriteLine("what do you want to do");
            Console.WriteLine("-'1'- Add a contact");
            Console.WriteLine("-'2'- Remove a contact");
            Console.WriteLine("-'3'- Show all contact");
            Console.WriteLine("-'4'- Clear Phone-Book");
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-'5'- EXIT");
            //Console.ResetColor();
        }

        public void LoggerForAdd()
        {
            Console.WriteLine("Ogoxlantirish : qo'shish uchun ism va raqam formatini to'g'ri yozing: (Sherzod +998918285636)");
            Console.Write("Ism va raqamni kiriting :");
        }

        public void LoggerForRemove()
        {
            Console.WriteLine("Ogoxlantirish : o'chirish uchun ism va raqam formatini to'g'ri yozing: (Sherzod +998918285636)");
            Console.Write("Ism va raqamni kiriting :");
        }

        public void LoggerExcepion(string message)
        {
            Console.WriteLine($"{message}");
            Console.WriteLine("Run again");
        }
        public void LogInformation(string message)
        {
            Console.WriteLine(message);
        }
    }
}