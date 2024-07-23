namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        string AddContactToTxtFile(string name, string phoneNumber);

        string AddContactToJsonFile(string name, string phoneNumber);

        void SearchContactFromTxtFile(string name, string phoneNumber);

        void SearchContactFromJsontFile(string name, string phoneNumber);

        void RemoveContactFromTxtFile(string name, string phoneNumber);

        void RemoveContactFromJsonFile(string name, string phoneNumber);

        void ReadContactFromTxtFile();

        void ReadContactFromJsonFile();

        void ClearAllContactFromTxtFile();

        void ClearAllContactFromJsonFile();


    }
}