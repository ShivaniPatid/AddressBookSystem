namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to Address Book Program");

            List<Contacts> list = new List<Contacts>();
            CreateContacts.CreateContactsInAddressBook(list);




            Console.WriteLine();
            Console.WriteLine("Choose a option");
            Console.WriteLine("1. Add a contacts in address book");
            Console.WriteLine("2. Edit the contact in address book");
            Console.WriteLine("3. Delete the contact in address book");
            Console.WriteLine("4. Add multiple person in address book");
            Console.WriteLine("5. Search person in address book");
            Console.WriteLine("6. Get number of contact person in address book");
            Console.WriteLine("7. sort the entries in the address book alphabetically by Person’s name");
            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    AddNewContacts.AddNewcontactsInAddressBook(list);                   
                     break;
                case 2:
                    EditExistingContact.EditExistingContactInAddressBook(list);
                    break;
                case 3:
                    DeleteContact.DeleteContactInAddreddBook(list);
                    break;
                case 4:
                    AddMultiplePerson.AddMultiplePersonInAddressBook(list);
                    break;
                case 5:
                    SearchPerson.SearchPersonInAddressBook(list);
                    break;
                case 6:
                    GetNumber.GetNumberInAddressBook(list);
                    break;
                case 7:
                    SortEntries.SortEntriesInAddressBook(list);
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            
        }
    }
}