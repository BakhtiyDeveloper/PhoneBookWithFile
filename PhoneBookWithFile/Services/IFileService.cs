namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        //void ReadContactFromTxtFile();

        //void ReadContactFromJsonFile();

        string AddContactToTxtFile(string name, string phoneNumber);

        string AddContactToJsonFile(string name, string phoneNumber);
    }
}