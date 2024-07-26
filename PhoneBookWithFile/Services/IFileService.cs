namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        string AddContactToTxtFile(string name, string phoneNumber);

        void SearchContactFromTxtFile(string name, string phoneNumber);
                
        void RemoveContactFromTxtFile(string name, string phoneNumber);

        void ReadContactFromTxtFile();

        void ClearAllContactFromTxtFile();

        


    }
}