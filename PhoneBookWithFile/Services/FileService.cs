using System;
using System.IO;


namespace PhoneBookWithFile.Services
{
    internal class FileService : IFileService
    {
        private const string txtFilePath = "../../../phoneBook.txt";
        private const string jsonFilePath = "../../../phoneBook.json";

        private ILoggingService loggingService;

        public FileService()
        {
            this.loggingService = new LoggingService();

            EnsureTxtFileExists();
            EnsureJsonFileExists();
        }

        private static void EnsureTxtFileExists()
        {
            bool isFilePresent = File.Exists(txtFilePath);

            if (isFilePresent is false)
            {
                File.Create(txtFilePath).Close();
            }

            Console.WriteLine("Phonebook txt yaratildi!!!");
        }

        private static void EnsureJsonFileExists()
        {
            bool isFilePresent = File.Exists(jsonFilePath);

            if (isFilePresent is false)
            {
                File.Create(jsonFilePath).Close();
            }

            Console.WriteLine("Phonebook json yaratildi!!!");
        }
    }
}