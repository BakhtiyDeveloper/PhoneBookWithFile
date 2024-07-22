namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        void AddNameAndNumber(string nameAndNumber);

        void RemoveNameAndNumber(string nameAndNumber);

        void ReplaceNumberAndName(string nameAndNumber);

        string ReadFile();

        void ClearFile();
    }
}