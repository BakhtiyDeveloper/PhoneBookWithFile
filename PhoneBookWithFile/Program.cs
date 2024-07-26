using PhoneBookWithFile;
using PhoneBookWithFile.Services;
using System;

IFileService fileService;
ILoggingService loggingService = new LoggingService();

loggingService.LogInformation("========== Welcome to our project ==========");
loggingService.LogInformation("In this project, you can work with contacts in the Phone book file");
loggingService.LogInformation("=======================================================\n\n");

loggingService.LogInformation("========== We have two types of files ==========");
loggingService.LogInformation("Which file you want to work with");
loggingService.LogInformation("-'1'- \"Phone book\" txt file!");
loggingService.LogInformation("-'2'- \"Phone book\" json file!");
loggingService.LogInformation("-'3'- EXIT");
loggingService.LogInformation("=======================================================\n\n");

string userChoose = loggingService.LogInformationAndGetUserValue("Choose one of the files: ");
bool isExit = true;

while (isExit)
{
    switch (userChoose)
    {
        case "1":
            Console.Clear();
            fileService = new FileService();
            break;

        case "2":
            Console.Clear();
            fileService = new JsonFileService();
            break;

        case "3":
            Console.Clear();
            loggingService.LogInformation("Thank you for using our project");
            isExit = false;
            break;
        default:
            loggingService.LogErrorInformation("You pressed the wrong button!");
            break;
    }
}

bool isExitByTxtFile = true;

while (isExitByTxtFile)
{
    loggingService.LogInformationMenu();

    loggingService.LogInformation("\nWarning : write name and number format correctly to add: (Sherzod +998918285636)\n");

    string userInterfaceChooseForTxtFile = loggingService.LogInformationAndGetUserValue("\nChoose one from the menu: ");

    switch (userInterfaceChooseForTxtFile)
    {
        case "1":
            string nameForAddContact = loggingService.LogInformationAndGetUserValue("Enter your name: ");
            string phoneNumberForAddContact = loggingService.LogInformationAndGetUserValue("Enter your phone number: ");
            fileService.AddContactToTxtFile(name: nameForAddContact, phoneNumber: phoneNumberForAddContact);
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
