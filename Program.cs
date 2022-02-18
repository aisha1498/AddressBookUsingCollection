using AddressBookUsingCollection;
internal class Program
{
    static void Main(string[] args)
    {
        AddressBook address = new AddressBook();
        Console.WriteLine("Welcome to the Address book system");
        Console.ReadLine();
        AddressBook.PersonDetails();
    }
}