namespace PhoneBookWithFile.Services
{
    internal interface ILoggingService
    {
        void LoggerMenu();

        void LoggerForAdd();

        void LoggerForRemove();

        void LoggerExcepion(string message);

        void LogInformation(string message);

    }
}