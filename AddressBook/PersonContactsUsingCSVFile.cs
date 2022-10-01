using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace AddressBook
{
    public class PersonContactsUsingCSVFile
    {
        public static void CsvSerialize(List<Contacts> list)
        {
            string csvFilePath = @"D:\visualstudio\AddressBookSystem\AddressBook\CsvData.txt";

            StreamWriter streamWriter = new StreamWriter(csvFilePath);
            CsvWriter csvWriter=new CsvWriter(streamWriter,CultureInfo.InvariantCulture);

            csvWriter.WriteRecords<Contacts>(list);
            streamWriter.Close();
            Console.WriteLine("Closed");
        }

        public static void CsvDeserialize()
        {
            string csvFilePath = @"D:\visualstudio\AddressBookSystem\AddressBook\CsvData.txt";

            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            List<Contacts> contacts = csvReader.GetRecords<Contacts>().ToList();
            foreach (Contacts contact in contacts)
            {
                contact.Show();
            }
        }
    }
}
