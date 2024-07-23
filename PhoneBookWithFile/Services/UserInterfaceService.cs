using System;
using System.Xml.Linq;

namespace PhoneBookWithFile.Services 
{ 
    internal class UserInterfaceService : IUserInterfaceService
    {
        IFileService fileService = new FileService();
        ILoggingService loggingService = new LoggingService();

        public void UseWithTxtFile()
        {
            bool isExitByTxtFile = true;

            while (isExitByTxtFile)
            {
                loggingService.LogInformationMenu();

                string userChoose = loggingService.LogInformationAndGetUserValue("Choose one from the menu: ");

                string name = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                string phoneNumber = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");

                switch (userChoose)
                {
                    case "1":
                        fileService.AddContactToTxtFile(name, phoneNumber);
                        break;

                    case "2":
                        fileService.RemoveContactFromTxtFile(name, phoneNumber);
                        break;

                    case "3":
                        fileService.ReadContactFromTxtFile();
                        break;

                    case "4":
                        fileService.SearchContactFromTxtFile(name, phoneNumber);
                        break;

                    case "5":
                        fileService.ClearAllContactFromTxtFile();
                        break;

                    case "6":
                        isExitByTxtFile = false;
                        break;

                    default:
                        loggingService.LogInformation("You pressed the wrong button!");
                        break;
                }
            }
        }

        public void UseWithJsonFile()
        {
            bool isExitByJsonFile = true;

            while (isExitByJsonFile)
            {
                loggingService.LogInformationMenu();

                string userChoose = loggingService.LogInformationAndGetUserValue("Choose one from the menu: ");

                string name = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                string phoneNumber = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");

                switch (userChoose)
                {
                    case "1":
                        fileService.AddContactToJsonFile(name, phoneNumber);
                        break;

                    case "2":
                        fileService.RemoveContactFromJsonFile(name, phoneNumber);
                        break;

                    case "3":
                        fileService.ReadContactFromJsonFile();
                        break;

                    case "4":
                        fileService.SearchContactFromJsontFile(name, phoneNumber);
                        break;

                    case "5":
                        fileService.ClearAllContactFromJsonFile();
                        break;

                    case "6":
                        isExitByJsonFile = false;
                        break;

                    default:
                        loggingService.LogInformation("You pressed the wrong button!");
                        break;
                }
            }
        }
    }
}
