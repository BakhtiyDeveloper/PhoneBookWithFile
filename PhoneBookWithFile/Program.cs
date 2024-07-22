using PhoneBookWithFile.Services;
using System;
using System.Linq;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILoggingService logger = new LoggingService();
            IFileService fileservice = new FileService();

            Console.WriteLine("Welcome to our Phone-Book project !!!");

            bool isExit = true;
            try
            {
                while (isExit)
                {
                    logger.LoggerMenu();
                    string userChoose = Console.ReadLine();
                    
                    switch (userChoose)
                    {
                        case "1":
                            fileservice.ReadFile().ToList().Sort();
                            logger.LoggerForAdd();
                            string nameAndNumber = Console.ReadLine();
                            fileservice.AddNameAndNumber(nameAndNumber);
                            nameAndNumber = "";
                            break;
                        case "2":
                            Console.Clear();
                            fileservice.ReadFile().ToList().Sort();
                            logger.LoggerForRemove();
                            nameAndNumber = Console.ReadLine();
                            fileservice.RemoveNameAndNumber(nameAndNumber);
                            break;
                        case "3":
                            Console.Clear();
                            fileservice.ReadFile().ToList().Sort();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Warning!!! Do you agree to delete the file: yes/no");
                            string chooseYesOrno = Console.ReadLine();
                            if (chooseYesOrno.ToLower() == "yes")
                            {
                                fileservice.ClearFile();
                            }
                            else
                            {
                                Console.Write("You did the right thing by not deleting the file!!!");
                            }
                            break;
                        case "5":
                            isExit = false;
                            break;
                        default:
                            Console.WriteLine("");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.LoggerExcepion(ex.Message);
            }
        }
    }
}