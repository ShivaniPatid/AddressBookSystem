using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace AddressBook
{
    public class PersonContactsUsingJSONFile
    {
        public static void Serialize(List<Contacts> list)
        {
            string csvFilePath = @"D:\visualstudio\AddressBookSystem\AddressBook\CsvPersonData.txt";

            StreamWriter streamWriter = new StreamWriter(csvFilePath);
            CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords<Contacts>(list);
            streamWriter.Close();
            Console.WriteLine("Closed");
        }

        public static void Deserialize()
        {
            string csvFilePath = @"D:\visualstudio\AddressBookSystem\AddressBook\CsvPersonData.txt";

            string jsonFilePath= @"D:\visualstudio\AddressBookSystem\AddressBook\jsonPersonData.txt";

            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            List<Contacts> contacts = csvReader.GetRecords<Contacts>().ToList();
            foreach (Contacts contact in contacts)
            {
                contact.Show();
            }

            JsonSerializer jsonSerializer = new JsonSerializer();
            using(StreamWriter stream=new StreamWriter(jsonFilePath))
                using(JsonWriter jsonWriter = new JsonTextWriter(stream))
                {
                    jsonSerializer.Serialize(jsonWriter, contacts);
                }
        }
    }
}
