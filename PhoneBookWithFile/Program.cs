using PhoneBookWithFile.Services;

namespace PhoneBookWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            FileService fileservice = new FileService();

            //fileservice.ClearFile();
            /*Console.WriteLine("Ogoxlantirish : ism va raqam formatini to'g'ri yozing; (Sherzod +998918285636)");
            Console.Write("Ism va raqamni kiriting :");

            string nameAndNumber = Console.ReadLine();



            fileservice.AddNameAndNumber(nameAndNumber);*/

            fileservice.ReadFile();

            // fileservice.ReadFile().ToList().Sort();

            /*Console.WriteLine("qaysi contactni o'chirishni istaysiz :(Sherzod +998918285636)");

            string nameAndNumber = Console.ReadLine();
            
            fileservice.RemoveNameAndNumber(nameAndNumber);
            Console.WriteLine("\n \tyangi phonebook:\n");
            fileservice.ReadFile();*/
        }

    }
}