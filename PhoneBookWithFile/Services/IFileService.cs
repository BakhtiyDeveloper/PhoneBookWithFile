namespace PhoneBookWithFile.Services
{
    internal interface IFileService
    {
        public void AddNameAndNumber(string nameAndNumber);

        public void RemoveNameAndNumber(string nameAndNumber);

        public void ReplaceNumberAndName(string nameAndNumber);

        public string ReadFile();


    }
}