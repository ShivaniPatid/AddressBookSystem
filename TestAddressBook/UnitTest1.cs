using AddressBook;

namespace TestAddressBook
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRetriveEnteries()
        {
            RetrieveEntries entries = new RetrieveEntries();

            entries.GetEntries();

        }


        [TestMethod]
        public void GivenContactDetailsAbleToUpdate()
        {
            UpdateContact update = new UpdateContact();
            ContactModel contact = new ContactModel();

            contact.FirstName = "Muskan";
            contact.Address = "Ujjain";
            contact.City = "Ujjain";
            contact.Zip = 456601;
            update.EditContact(contact);

           
            
        }
    }
}