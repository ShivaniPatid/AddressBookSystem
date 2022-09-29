using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class SearchPerson
    {
        public static void SearchPersonInAddressBook(List<Contacts> list)
        {

            foreach (var contact in list.FindAll(e=>(e.City=="Indore" && e.State== "Madhya Pradesh")).ToList())
            {
                //contact.Show();
                
                Console.WriteLine(contact.FirstName);
            }
        }
    }
}
