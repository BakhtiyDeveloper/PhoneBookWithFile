namespace PhoneBookWithFile.Services
{
    internal interface ILoggingService
    {
        void LogInformation(string message);

        void LogErrorInformation(string message);
    }
}