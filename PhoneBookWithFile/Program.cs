using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserInterfaceService userservice = new UserInterfaceService();
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
                        userservice.UseWithTxtFile();
                        break;

                    case "2":
                        Console.Clear();
                        userservice.UseWithJsonFile();
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
        }
    }
}