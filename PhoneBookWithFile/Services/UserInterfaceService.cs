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
                loggingService.LogInformation("You are working with the phonebook.txt file!!!!\n");
                loggingService.LogInformationMenu();

                string userInterfaceChooseForTxtFile = loggingService.LogInformationAndGetUserValue("\nChoose one from the menu: ");
                
                loggingService.LogInformation("\nWarning : write name and number format correctly to add: (Sherzod +998918285636)\n");
                
                switch (userInterfaceChooseForTxtFile)
                {
                    case "1":
                        string nameForAddContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForAddContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        fileService.AddContactToTxtFile(nameForAddContact, phoneNumberForAddContact);
                        loggingService.LogInformationTheProgress("Add contact");
                        break;

                    case "2":
                        string nameForRemoveContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForRemoveContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        fileService.RemoveContactFromTxtFile(nameForRemoveContact, phoneNumberForRemoveContact);
                        loggingService.LogInformationTheProgress("Remove contact");
                        break;

                    case "3":
                        fileService.ReadContactFromTxtFile();
                        loggingService.LogInformationTheProgress("Read contact");
                        break;

                    case "4":
                        string nameForSearchContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForSearchContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        fileService.SearchContactFromTxtFile(nameForSearchContact, phoneNumberForSearchContact);
                        break;

                    case "5":
                        Console.Clear();
                        loggingService.LogInformation("Do you want to delete all contacts in the phone book txt file!!! ==y/n==");
                        string answer = Console.ReadLine();

                        if (answer == "y" || answer == "Y") 
                        {
                           fileService.ClearAllContactFromTxtFile();
                        }
                        else 
                        {
                            isExitByTxtFile = false;
                        }     
                        break;

                    case "6":
                        Console.Clear();
                        loggingService.LogInformation("-'6'- We have selected to ====Exit to program====");
                        loggingService.LogInformation("Thank you for using our project");
                        isExitByTxtFile = false;
                        break;

                    default:
                        Console.Clear();
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
                loggingService.LogInformation("You are working with the phonebook.json file!!!!\n");
                loggingService.LogInformationMenu();

                string userInterfaceChooseForJsonFile = loggingService.LogInformationAndGetUserValue("Choose one from the menu: ");
                
                loggingService.LogInformation("Warning : write name and number format correctly to add: (Sherzod +998918285636)");

                switch (userInterfaceChooseForJsonFile)
                {
                    case "1":
                        string nameForAddContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForAddContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        fileService.AddContactToJsonFile(nameForAddContact, phoneNumberForAddContact);
                        loggingService.LogInformationTheProgress("Add contact");
                        break;

                    case "2":
                        string nameForRemoveContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForRemoveContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        loggingService.LogInformationTheProgress("Remove contact");
                        break;

                    case "3":
                        fileService.ReadContactFromJsonFile();
                        loggingService.LogInformationTheProgress("Read contact");
                        break;

                    case "4":
                        string nameForSearchContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
                        string phoneNumberForSearchContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
                        fileService.SearchContactFromJsontFile(nameForSearchContact, phoneNumberForSearchContact);
                        break;

                    case "5":
                        Console.Clear();
                        loggingService.LogInformation("Do you want to delete all contacts in the phone book json file!!! ==y/n==");
                        string answer = Console.ReadLine();

                        if (answer == "y" || answer == "Y")
                        {
                            fileService.ClearAllContactFromJsonFile();
                        }
                        else
                        {
                            isExitByJsonFile = false;
                        }                        
                        break;

                    case "6":
                        Console.Clear();
                        loggingService.LogInformation("-'6'- We have selected to ====Exit to program====");
                        loggingService.LogInformation("Thank you for using our project");
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
