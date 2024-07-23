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

                string userInterfaceChooseForTxtFile = loggingService.LogInformationAndGetUserValue("Choose one from the menu: ");
                
                string name = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                string phoneNumber = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                                

                switch (userInterfaceChooseForTxtFile)
                {
                    
                    case "1":
                        fileService.AddContactToTxtFile(name, phoneNumber);
                        break;

                    case "2":
                        loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
                        fileService.RemoveContactFromTxtFile(name, phoneNumber);
                        break;

                    case "3":
                        fileService.ReadContactFromTxtFile();
                        break;

                    case "4":
                        loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
                        fileService.SearchContactFromTxtFile(name, phoneNumber);
                        break;

                    case "5":
                        fileService.ClearAllContactFromTxtFile();
                        break;

                    case "6":
                        isExitByTxtFile = false;
                        break;

                    default:
                        loggingService.LogErrorInformation("You pressed the wrong button!");
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

                string userInterfaceChooseForJsonFile = loggingService.LogInformationAndGetUserValue("Choose one from the menu: ");

                string name = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                string phoneNumber = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");

                switch (userInterfaceChooseForJsonFile)
                {
                    case "1":
                        loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
                        fileService.AddContactToJsonFile(name, phoneNumber);
                        break;

                    case "2":
                        loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
                        fileService.RemoveContactFromJsonFile(name, phoneNumber);
                        break;

                    case "3":
                        fileService.ReadContactFromJsonFile();
                        break;

                    case "4":
                        loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");
                        fileService.SearchContactFromJsontFile(name, phoneNumber);
                        break;

                    case "5":
                        fileService.ClearAllContactFromJsonFile();
                        break;

                    case "6":
                        isExitByJsonFile = false;
                        break;

                    default:
                        loggingService.LogErrorInformation("You pressed the wrong button!");
                        break;
                }
            }
        }
    }
}
