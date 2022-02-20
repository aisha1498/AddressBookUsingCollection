using AddressBookUsingCollection;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Address book system");
        //uc-1 creating a contact
        Console.WriteLine("Welcome to Address Book using Collection");
        //uc-2 adding of first and last names, address,city, state, zip, phone number and email...
        AddressBook.AddContact();
        Console.WriteLine("\n");
        AddressBook.ContactsDisplay();
        Console.WriteLine("\n");
        //Uc-3 edit existing contact person using their name
        AddressBook.EditContact();
        Console.WriteLine("\n");
        AddressBook.ContactsDisplay();
        Console.WriteLine("\n");
        //uc-4 delete a person using person's name 
        AddressBook.DeleteContact();
    }
}