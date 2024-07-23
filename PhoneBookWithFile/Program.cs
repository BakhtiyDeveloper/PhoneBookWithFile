using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileService fileService = new FileService();

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            fileService.AddContactToTxtFile(name, phoneNumber);

            fileService.AddContactToJsonFile(name, phoneNumber);

            fileService.ReadContactFromTxtFile();

            fileService.ReadContactFromJsonFile();

            fileService.RemoveContactFromTxtFile(name, phoneNumber);

            fileService.RemoveContactFromJsontFile(name, phoneNumber);

            fileService.ClearAllContactFromTxtFile();

            fileService.ClearAllContactFromJsonFile();

            Console.ReadLine();
        }
    }
}