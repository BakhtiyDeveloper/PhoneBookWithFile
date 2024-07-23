namespace PhoneBookWithFile.Services
{
    internal interface ILoggingService
    {
        void LogInformation(string message);

        void LogErrorInformation(string message);

        void LogInformationTheProgress(string message);

        string LogInformationAndGetUserValue(string message);

    }
}