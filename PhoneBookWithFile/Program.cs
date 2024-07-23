using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new FileService();
            ILoggingService loggingService = new LoggingService();
                        
            string name = loggingService.LogInformationAndGetUserValue("Enter your name: ");

            string phoneNumber = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");

            fileService.AddContactToTxtFile(name, phoneNumber);

            fileService.AddContactToJsonFile(name, phoneNumber);

            fileService.RemoveContactFromTxtFile(name, phoneNumber);

            fileService.RemoveContactFromJsontFile(name, phoneNumber);

            fileService.SearchContactFromTxtFile(name, phoneNumber);

            fileService.SearchContactFromJsontFile(name, phoneNumber);

            fileService.ReadContactFromTxtFile();

            fileService.ReadContactFromJsonFile();

            fileService.ClearAllContactFromTxtFile();

            fileService.ClearAllContactFromJsonFile();

            Console.ReadLine();
        }
    }
}