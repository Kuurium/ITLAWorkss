using System;
using System.Collections.Generic;
using System.Linq; 

public class Program
{
    
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("My Awesome Agenda");
        Console.WriteLine("Welcome to your contact list");

        
        List<Contact> contacts = new List<Contact>();

        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- MAIN MENU ---");
            Console.Write("1. Add Contact      ");
            Console.Write("2. View Contacts     ");
            Console.Write("3. Search/Edit Contact        ");
            Console.Write("4. Delete Contact     ");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            
            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine(">>> Error: Please enter a valid number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddContact(contacts);
                    break;
                case 2:
                    ViewContacts(contacts);
                    break;
                case 3:
                    SearchOrEditContact(contacts); 
                    break;
                case 4:
                    DeleteContact(contacts);
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine(">>> Option not valid");
                    break;
            }
        }
    }

    

    static void AddContact(List<Contact> contactsList)
    {
        Console.WriteLine("\n--- ADD CONTACT ---");
        Console.WriteLine("Let's add a new contact.");

        int newId = contactsList.Count + 1;

        Contact newContact = new Contact();
        newContact.Id = newId;

        Console.Write("Enter Name: ");
        newContact.Name = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        newContact.Phone = Console.ReadLine();

        Console.Write("Enter Email: ");
        newContact.Email = Console.ReadLine();

        Console.Write("Enter Address: ");
        newContact.Address = Console.ReadLine();

        contactsList.Add(newContact);
        Console.WriteLine(">>> Contact added successfully!");
    }

    static void ViewContacts(List<Contact> contactsList)
    {
        Console.WriteLine("\n--- CONTACT LIST ---");
        Console.WriteLine("Id    Name            Phone               Email           Address");
        Console.WriteLine("___________________________________________________________________________");

        foreach (Contact contact in contactsList)
        {
            Console.WriteLine($"{contact.Id}    {contact.Name}      {contact.Phone}      {contact.Email}     {contact.Address}");
        }
    }

    static void SearchOrEditContact(List<Contact> contactsList)
    {
        Console.WriteLine("\n--- SEARCH OR EDIT CONTACT ---");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Search (View Details)");
        Console.WriteLine("2. Edit Contact");
        Console.Write("Choose an option: ");

        
        if (!int.TryParse(Console.ReadLine(), out int subOption) || (subOption != 1 && subOption != 2))
        {
            Console.WriteLine(">>> Error: Invalid option. Returning to main menu.");
            return;
        }

        
        ViewContacts(contactsList);

        Console.Write("\nEnter the Contact ID: ");

        
        if (!int.TryParse(Console.ReadLine(), out int selectedId))
        {
            Console.WriteLine(">>> Error: Invalid ID format. Please enter a number.");
            return;
        }

        
        Contact foundContact = contactsList.Find(c => c.Id == selectedId);

        if (foundContact == null)
        {
            Console.WriteLine(">>> No contact found with that ID.");
            return;
        }

        

        if (subOption == 1) 
        {
            Console.WriteLine("\n--- CONTACT DETAILS ---");
            Console.WriteLine($"ID:      {foundContact.Id}");
            Console.WriteLine($"Name:    {foundContact.Name}");
            Console.WriteLine($"Phone:   {foundContact.Phone}");
            Console.WriteLine($"Email:   {foundContact.Email}");
            Console.WriteLine($"Address: {foundContact.Address}");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
        else if (subOption == 2) 
        {
            Console.WriteLine($"\nEditing contact: {foundContact.Name}");
            Console.WriteLine("(Tip: Press Enter to keep the current value)");

            

            Console.Write($"Current Name ({foundContact.Name}) - New Name: ");
            string newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName)) foundContact.Name = newName;

            Console.Write($"Current Phone ({foundContact.Phone}) - New Phone: ");
            string newPhone = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPhone)) foundContact.Phone = newPhone;

            Console.Write($"Current Email ({foundContact.Email}) - New Email: ");
            string newEmail = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newEmail)) foundContact.Email = newEmail;

            Console.Write($"Current Address ({foundContact.Address}) - New Address: ");
            string newAddress = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newAddress)) foundContact.Address = newAddress;

            Console.WriteLine(">>> Contact updated successfully!");
        }
    }

    static void DeleteContact(List<Contact> contactsList)
    {
        Console.WriteLine("\n--- DELETE CONTACT ---");

        foreach (Contact contact in contactsList)
        {
            Console.WriteLine($"ID: {contact.Id} - Name: {contact.Name}");
        }

        Console.Write("\nEnter the ID of the contact to delete: ");

        
        if (!int.TryParse(Console.ReadLine(), out int idToDelete))
        {
            Console.WriteLine(">>> Error: Invalid ID format. Please enter a number.");
            return;
        }

        Contact contactToDelete = contactsList.Find(c => c.Id == idToDelete);

        if (contactToDelete == null)
        {
            Console.WriteLine(">>> No contact found with that ID.");
            return;
        }

        Console.WriteLine($"\nContact found for deletion:");
        Console.WriteLine($"Name: {contactToDelete.Name}");
        Console.WriteLine($"Phone: {contactToDelete.Phone}");
        Console.WriteLine($"Email: {contactToDelete.Email}");
        Console.WriteLine($"Address: {contactToDelete.Address}");
        Console.WriteLine($"ID: {contactToDelete.Id}");

        Console.WriteLine("\nAre you sure you want to delete this contact?");
        Console.WriteLine("1. Yes");
        Console.WriteLine("2. No");
        Console.Write("Select an option: ");

        
        if (!int.TryParse(Console.ReadLine(), out int option))
        {
            Console.WriteLine(">>> Invalid option. Deletion cancelled.");
            return;
        }

        if (option == 1)
        {
            contactsList.Remove(contactToDelete);
            Console.WriteLine(">>> Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine(">>> Deletion cancelled.");
        }
    }
}