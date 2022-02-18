using AddressBookUsingCollection;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Address book system");
        Console.ReadLine();
        AddressBookUsingCollection.AddressBook.RemovePeople();

        AddressBookUsingCollection.AddressBook.GetCustomer();

        AddressBookUsingCollection.AddressBook.ListingPeople();
    }
}