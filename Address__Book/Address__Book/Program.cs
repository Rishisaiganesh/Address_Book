using System;
using static Address__Book.ContactDetails;

namespace Address__Book
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Address Book Sysyem");
           // Contacts contacts = new Contacts();
           // contacts.FirstName = "Rishisai";
           // contacts.LastName = "Ganesh";
           // contacts.PhoneNumber = 9849842012;
            //contacts.State = "AP";
           // contacts.City = "Nellore";
           // contacts.Email = "Abcd.@gmail.com";
           // contacts.ZipCode = 524001;
           // contacts.ValidateContactDetails();
            //Console.WriteLine("Contact Details: ");
           // Console.WriteLine("Full Name" + contacts.FirstName + "  " + contacts.LastName);
            //Console.WriteLine("Phone Number=" + contacts.PhoneNumber);
           // Console.WriteLine("Address =" + contacts.City + "  " + contacts.State + "  " + contacts.ZipCode);
          //  Console.WriteLine("Email Id =" + contacts.Email);
           // AddingNewContacts Add = new AddingNewContacts();
           // Add.AddingNewContact();
            NewContact check = new NewContact();
            check.CheckDetails();
            check.Selection();

        }
    }
}
