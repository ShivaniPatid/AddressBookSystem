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
            Console.WriteLine("7. Read or Write the Address Book with Persons Contact into a File using File IO");
            Console.WriteLine("8. Read/Write the Address Book with Persons Contact as CSV File");
            Console.WriteLine("9. Read or Write the Address Book with Persons Contact as JSON File");
            Console.WriteLine("10. Get all enteries to DB");
            Console.WriteLine("11. Update Enteries");
            Console.WriteLine("12. Retrive enteries by City and State");
            Console.WriteLine("13. Add Contacts to the address book database");
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
                    PersonContactUsingFileIO personContactUsingFileIO = new PersonContactUsingFileIO();
                    personContactUsingFileIO.Serialize(list);
                    personContactUsingFileIO.Deserialize();
                    break;
                case 8:
                    PersonContactsUsingCSVFile.CsvSerialize(list);
                    PersonContactsUsingCSVFile.CsvDeserialize();
                    break;
                case 9:
                    PersonContactsUsingJSONFile.Serialize(list);
                    PersonContactsUsingJSONFile.Deserialize();
                    break;
                case 10:
                    RetrieveEntries entries=new RetrieveEntries();
                    entries.GetEntries();
                    break;
                case 11:

                    UpdateContact update = new UpdateContact();
                    ContactModel contact = new ContactModel();

                    contact.FirstName = "Muskan";
                    contact.Address = "Ujjain";
                    contact.City = "Ujjain";
                    contact.Zip = 456601;

                    update.Equals(contact);

                    break;
                case 12:
                    RetrievePerson person = new RetrievePerson();
                    person.RetrievePersonDetails();
                    break;
                case 13:
                    InsertContact insert = new InsertContact();
                    ContactModel contacts = new ContactModel();
                    contacts.FirstName = "Saloni";
                    contacts.LastName = "Sharma";
                    contacts.Address = "Indore";
                    contacts.City = "Indore";
                    contacts.State = "Madhya Pradesh";
                    contacts.Zip = 456661;
                    contacts.PhoneNumber = 7755869423;
                    contacts.Email = "saloni@gmail.com";

                    insert.AddContact(contacts);
                    break;
                case 14:
                    InsertContactUsingThread insertcontact = new InsertContactUsingThread();
                    ContactModel contacts1 = new ContactModel();
                    contacts1.FirstName = "Disha";
                    contacts1.LastName = "Sharma";
                    contacts1.Address = "Indore";
                    contacts1.City = "Indore";
                    contacts1.State = "Madhya Pradesh";
                    contacts1.Zip = 456661;
                    contacts1.PhoneNumber = 7755869423;
                    contacts1.Email = "saloni@gmail.com";

                    insertcontact.AddContact(contacts1);
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            
        }
    }
}