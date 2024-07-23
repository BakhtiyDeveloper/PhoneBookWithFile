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

            Console.ReadLine();
        }
    }
}