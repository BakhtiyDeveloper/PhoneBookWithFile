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
        }

        private static void EnsureJsonFileExists()
        {
            bool isFilePresent = File.Exists(jsonFilePath);

            if (isFilePresent is false)
            {
                File.Create(jsonFilePath).Close();
            }
        }

        public string AddContactToTxtFile(string name, string phoneNumber)
        {
            File.AppendAllText(txtFilePath, name + phoneNumber);

            return name + phoneNumber;
        }

        public string AddContactToJsonFile(string name, string phoneNumber)
        {
            File.AppendAllText(jsonFilePath, name + phoneNumber);

            return name + phoneNumber;
        }

        //public void ReadContactFromTxtFile()
        //{
        //    loggingService.LogInformation("======== Phonbook.txt file ========");
        //    string[] contactsForTxtFile = File.ReadAllLines(txtFilePath);

        //    foreach (string contact in contactsForTxtFile)
        //    {
        //        string[] stringsForTxtFile = contact.Split("/");
        //        loggingService.LogInformation($"Name: {stringsForTxtFile[0]} Number: {stringsForTxtFile[1]}");
        //    }
        //}

        //public void ReadContactFromJsonFile()
        //{
        //    loggingService.LogInformation("======== Phonbook.json file ========");
        //    string[] contactsForJsonFile = File.ReadAllLines(jsonFilePath);

        //    foreach (string contact in contactsForJsonFile)
        //    {
        //        string[] stringsForJsonFile = contact.Split("/");
        //        loggingService.LogInformation($"Name: {stringsForJsonFile[0]} Number: {stringsForJsonFile[1]}");
        //    }
        //}




    }
}