using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber)) 
            {
                loggingService.LogErrorInformation("The name or phone number was entered incorrectly." +
                                                   "Enter the correct values.");

                return " ";
            }
            else 
            {
                File.AppendAllText(txtFilePath, name + " " + phoneNumber + "\n");

                return name + " " + phoneNumber + "\n";
            }
        }

        public string AddContactToJsonFile(string name, string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                loggingService.LogErrorInformation("The name or phone number was entered incorrectly." +
                                                   "Enter the correct values.");

                return " ";
            }
            else
            {
                File.AppendAllText(jsonFilePath, name + " " + phoneNumber + "\n");

                return name + " " + phoneNumber + "\n";
            }
        }

        public void ReadContactFromTxtFile()
        {
            loggingService.LogInformation("\n======== Phonbook.txt file ========");
            string[] contactsForTxtFile = File.ReadAllLines(txtFilePath);

            foreach (string contact in contactsForTxtFile)
            {
                string[] stringsForTxtFile = contact.Split(" ");
                loggingService.LogInformation($"Name: {stringsForTxtFile[0]}, Number: {stringsForTxtFile[1]}");
            }
        }

        public void ReadContactFromJsonFile()
        {

            loggingService.LogInformation("\n======== Phonbook.json file ========");
            string[] contactsForJsonFile = File.ReadAllLines(jsonFilePath);

            foreach (string contact in contactsForJsonFile)
            {
                string[] stringsForJsonFile = contact.Split(" ");
                loggingService.LogInformation($"Name: {stringsForJsonFile[0]}, Number: {stringsForJsonFile[1]} ");

            }
        }

        public void ClearAllContactFromTxtFile()
        {
            File.WriteAllText(txtFilePath, string.Empty);
        }

        public void ClearAllContactFromJsonFile()
        {
            File.WriteAllText(jsonFilePath, string.Empty);
        }

        public void RemoveContactFromTxtFile(string name, string phoneNumber)
        {
            List<string> linesByTxtFile = File.ReadAllLines(txtFilePath).ToList();

            string lineToRemoveByTxtFile = name + phoneNumber;

            linesByTxtFile.Remove(lineToRemoveByTxtFile);

            File.WriteAllLines(txtFilePath, linesByTxtFile);
        }

        public void RemoveContactFromJsontFile(string name, string phoneNumber)
        {
            List<string> linesByJsonFile = File.ReadAllLines(jsonFilePath).ToList();

            string lineToRemoveByJsonFile = name + phoneNumber;

            linesByJsonFile.Remove(lineToRemoveByJsonFile);

            File.WriteAllLines(txtFilePath, linesByJsonFile);
        }

        public void SearchContactFromTxtFile(string name, string phoneNumber)
        {
            loggingService.LogInformation("\n======== Phonbook.txt file ========");
            
            string[] linesFromTxtFile = File.ReadAllLines(txtFilePath);
            
            foreach (string line in linesFromTxtFile)
            {
                string[] stringsForTxtFile = line.Split(" ");
                
                if (stringsForTxtFile[0] == name && stringsForTxtFile[1] == phoneNumber) 
                {
                    loggingService.LogInformation("=== The name and phone number you searched for ===");
                    loggingService.LogInformation($"Name: {stringsForTxtFile[0]}, Number: {stringsForTxtFile[1]}");
                }
                else
                {
                    loggingService.LogErrorInformation("The name or phone number you searched does not exit!!!");
                }

            }


        }

        public void SearchContactFromJsontFile(string name, string phoneNumber)
        {
            loggingService.LogInformation("\n======== Phonbook.json file ========");

            string[] linesFromJsonFile = File.ReadAllLines(jsonFilePath);

            foreach (string line in linesFromJsonFile)
            {
                string[] stringsForJsonFile = line.Split(" ");

                if (stringsForJsonFile[0] == name && stringsForJsonFile[1] == phoneNumber)
                {
                    loggingService.LogInformation("=== The name and phone number you searched for ===");
                    loggingService.LogInformation($"Name: {stringsForJsonFile[0]}, Number: {stringsForJsonFile[1]}");
                }
                else
                {
                    loggingService.LogErrorInformation("The name or phone number you searched does not exit!!!");
                }
            }
        }
    }
}