using PhoneBookWithFile.Services;
using System;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();

            //fileService.ClearFile();

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            Console.Write("Enter your phoneNumber: ");
            string userPhoneNumber = Console.ReadLine();

            fileService.AddNameAndNumber(userName, userPhoneNumber);


        }
    }
}
