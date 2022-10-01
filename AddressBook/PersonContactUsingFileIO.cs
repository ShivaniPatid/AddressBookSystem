using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class PersonContactUsingFileIO
    {
        public void Serialize(List<Contacts> list)
        {
            FileStream file = new FileStream(@"D:\visualstudio\AddressBookSystem\AddressBook\Contacts.txt", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, list);
            file.Close();
        }

        public void Deserialize()
        {
            FileStream fileStream = new FileStream(@"D:\visualstudio\AddressBookSystem\AddressBook\Contacts.txt", FileMode.Open);
            BinaryFormatter formatter=new BinaryFormatter();
            Contacts deserialize = (Contacts)formatter.Deserialize(fileStream);

            deserialize.Show();

        }
    }
}
