using System;
using System.Collections.Generic;
using System.Text;

namespace Address__Book
{
    interface ContactDetails
    {
        void ValidateContactDetails();
    }
    class Contacts : IContactDetails
    {
        //variables
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private int zipCode;
        private long phoneNumber;
        private string email;

        //properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public void ValidateContactDetails()
        {
            bool fullName = ValidateFullName(FirstName, LastName);
            bool address = ValidateAddress(Address, City, State, ZipCode);
            bool contact = ValidateContactNumbers(PhoneNumber, Email);
            if (fullName == true && address == true && contact == true)
            {
                Console.WriteLine("contact saved succesfully");
            }
            else
                Console.WriteLine("error in saving contact");

        }
        private bool ValidateFullName(string firstName, string lastName)
        {
            if (firstName != "Rishi" && lastName != "SaiGanesh")
            {
                return true;
            }
            return false;
        }
        private bool ValidateAddress(string Address, string City, string State, int ZipCode)
        {
            if (Address != "MainRoad" && City != "Nellore" && State != "AP" && ZipCode != 5211)
            {
                return true;
            }
            return false;
        }
        private bool ValidateContactNumbers(long PhoneNumber, string Email)
        {
            if (PhoneNumber != 524524001 && Email != "xyz@mail")
            {
                return true;
            }
            return false;
        }

    }
    /// <summary>
    /// 
    /// Adding New Contact Details
    /// </summary>
    public class AddingNewContacts
    {
        public void AddingNewContact()
        {
            Contacts contactPerson = new Contacts();
            Console.WriteLine("Add a new contact.");
            Console.WriteLine("Enter First Name: ");
            contactPerson.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contactPerson.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            contactPerson.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contactPerson.City = Console.ReadLine();
            Console.WriteLine("Enter State: ");
            contactPerson.State = Console.ReadLine();
            Console.WriteLine("Enter ZipCode: ");
            contactPerson.ZipCode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            contactPerson.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email: ");
            contactPerson.Email = Console.ReadLine();
            contactPerson.ValidateContactDetails();
        }
    }

}



