using System;
using System.IO;

namespace PhoneBookWithFile.Services
{
    internal class FileService : IFileService
    {
        private const string filePath = "../../../phoneBook.txt";
        private ILoggingService loggingService;

        public FileService()
        {
            this.loggingService = new LoggingService();

            EnsureFileExists();
        }

        public void ClearFile() 
        {
            File.WriteAllText(filePath, string.Empty);
        }

        public string AddNameAndNumber(string name, string number) 
        {
            string space = " ";
            string line = "\n";
            File.AppendAllText(filePath, name + space + number + line);
            return name + number;
        }
        
        public void ReadFile() 
        {
            string readText = File.ReadAllText(filePath);
            Console.WriteLine(readText);            
        } 

        private static void EnsureFileExists()
        {
            bool isFilePresent = File.Exists(filePath);

            if (isFilePresent is false)
            {
                File.Create(filePath).Close();
            }
        }
    }
}
