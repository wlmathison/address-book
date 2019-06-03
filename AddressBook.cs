using System;
using System.Collections.Generic;

namespace addressBook
{

    class AddressBook
    {
        private Dictionary<string, Contact> ContactList = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            try
            {
                ContactList.Add(contact.Email, contact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"A contact with email of {contact.Email} already exists.");
            }
        }
        public Contact GetByEmail(string email)
        {
            return ContactList[email];
        }
    }
}