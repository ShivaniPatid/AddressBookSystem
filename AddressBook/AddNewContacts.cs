using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddNewContacts
    {
        public static void AddNewcontactsInAddressBook()
        {
            Contacts user1 = new Contacts("Shivani", "Patidar", "Patpala", "Ujjain", "Madhya Pradesh", "456060", "8897798662", "shivani@gmail.com");
            Contacts user2 = new Contacts("Arpita", "Patidar", "Maksi", "Ujjain", "Madhya Pradesh", "456160", "9023254862", "arpita@gmail.com");
            Contacts user3 = new Contacts("Ronak", "Sharma", "Ujjain", "Ujjain", "Madhya Pradesh", "456010", "6264589721", "ronak@gmail.com");
            Contacts user4 = new Contacts("Roanak", "Patil", "Mhow", "Indore", "Madhya Pradesh", "456611", "7788256341", "abhishek@gmail.com");
            Contacts user5 = new Contacts("Manoj", "Tiwari", "Rau", "Indore", "Madhya Pradesh", "4566612", "8090263548", "manoj@gmail.com");

            LinkedList<Contacts> list = new LinkedList<Contacts>();
            list.AddLast(user1);
            list.AddLast(user2);
            list.AddLast(user3);
            list.AddLast(user4);
            list.AddLast(user5);
            foreach (Contacts contact in list)
            {
                contact.Show();
            }

            Console.WriteLine("Add a new contacts in adderss book");
            Console.WriteLine("Enter a First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter a Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter a Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter a state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter a city");
            string city = Console.ReadLine();
            Console.WriteLine("Enter a zip code");
            string zip = Console.ReadLine();
            Console.WriteLine("Enter a phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter a email");
            string email = Console.ReadLine();
            Contacts user6=new Contacts(firstName,lastName,address,city,state,zip,phoneNumber,email);
            
            list.AddLast(user6);
            foreach (Contacts contact in list)
            {
                contact.Show();
            }
        }


    }
}
