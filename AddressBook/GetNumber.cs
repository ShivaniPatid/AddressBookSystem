using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class GetNumber
    {
        public static void GetNumberInAddressBook(List<Contacts> list)
        {
            foreach (var contact in list.FindAll(e => (e.City == "Indore" && e.State == "Madhya Pradesh")).ToList())
            {
                //contact.Show();

                Console.WriteLine("Name : "+contact.FirstName+"\t"+"Number : "+contact.PhoneNumber);
            }
        }
    }
}
