using AddressBookUsingCollection;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book using Collection");
        //uc-6 add multiple Address Book to the System Each Address Book has a unique Name 
        AddressBook.addAddressBook();
        Console.WriteLine("\n");
        AddressBook.ContactsDisplay();
        Console.WriteLine("\n");
        AddressBook.EditContact();
        Console.WriteLine("\n");
        AddressBook.ContactsDisplay();
        Console.WriteLine("\n");
        AddressBook.ContactsDisplay();
        AddressBook.ContactsDisplay();
        AddressBook.ContactsDisplay();
        AddressBook.ContactsDisplay();
    }
}