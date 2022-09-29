using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContacts
    {
        public static void CreateContactsInAddressBook(List<Contacts> list)
        {
            Contacts user1 = new Contacts("Shivani", "Patidar", "11 Street", "Ujjain", "Madhya Pradesh", "456060", "8897798662", "shivani@gmail.com");
            Contacts user2 = new Contacts("Arpita", "Patidar", "12 Street", "Ujjain", "Madhya Pradesh", "456160", "9023254862", "arpita@gmail.com");
            Contacts user3 = new Contacts("Ronak", "Sharma", "13 Street", "Ujjain", "Madhya Pradesh", "456010", "6264589721", "ronak@gmail.com");
            Contacts user4 = new Contacts("Roanak", "Patil", "14 Street", "Indore", "Madhya Pradesh", "456611", "7788256341", "abhishek@gmail.com");
            Contacts user5 = new Contacts("Manoj", "Tiwari", "15 Street", "Indore", "Madhya Pradesh", "4566612", "8090263548", "manoj@gmail.com");
            
            
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);
            list.Add(user4);
            list.Add(user5);
            foreach (Contacts contact in list)
            {
                contact.Show();
            }




        }
    }
}
