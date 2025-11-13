Console.WriteLine("Welcome to my Contact List");


bool running = true;
List<int> ids = new List<int>();
Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> telephones = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> bestFriends = new Dictionary<int, bool>();


while (running)
{
    Console.WriteLine("\n--- Contact Menu ---");
    
    Console.WriteLine(@"1. Add Contact          2. View Contacts    3. Search Contacts      4. Modify Contact       5. Delete Contact       6. Exit");
    Console.WriteLine("Enter the number of the desired option");

    
    if (!int.TryParse(Console.ReadLine(), out int typeOption))
    {
        Console.WriteLine("\n Error: Invalid option. Please enter a number.");
        continue;
    }

    switch (typeOption)
    {
        case 1: 
            {
                AddContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
            }
            break;

        case 2: 
            {
                Console.WriteLine("\n--- Contact List ---");
                
                Console.WriteLine($"ID              Name            Lastname            Address                 Phone               Email               Age             Is Best Friend?");
                Console.WriteLine($"________________________________________________________________________________________________________________________________________________________");

                if (ids.Count == 0)
                {
                    Console.WriteLine("No contacts saved yet.");
                }

                foreach (var id in ids)
                {
                    var isBestFriend = bestFriends[id];
                    string isBestFriendStr = (isBestFriend == true) ? "Yes" : "No";

                    
                    Console.WriteLine($"{id,-15} {names[id],-15} {lastnames[id],-19} {addresses[id],-23} {telephones[id],-19} {emails[id],-19} {ages[id],-15} {isBestFriendStr}");
                }
                Console.WriteLine("________________________________________________________________________________________________________________________________________________________");
            }
            break;

        case 3: 
            {
                Console.WriteLine("\nEnter the name or part of the name you want to search for");
                string searchTerm = Console.ReadLine();

                Console.WriteLine($"\nID              Name            Lastname            Address                 Phone               Email               Age             Is Best Friend?");
                Console.WriteLine($"________________________________________________________________________________________________________________________________________________________");

                bool found = false;

                foreach (var item in names)
                {
                    
                    if (item.Value.ToLower().Contains(searchTerm.ToLower()))
                    {
                        var isBestFriend = bestFriends[item.Key];
                        string isBestFriendStr = (isBestFriend == true) ? "Yes" : "No";
                        int id = item.Key;

                        
                        Console.WriteLine($"{id,-15} {names[id],-15} {lastnames[id],-19} {addresses[id],-23} {telephones[id],-19} {emails[id],-19} {ages[id],-15} {isBestFriendStr}");
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("\nNo contacts matching the search were found.");
                }
            }
            break;

        case 4: 
            {
                Console.WriteLine("\nEnter the ID of the contact you want to modify");

                if (!int.TryParse(Console.ReadLine(), out int idToModify))
                {
                    Console.WriteLine("\n Error: The ID must be a number.");
                    break;
                }

                if (names.ContainsKey(idToModify))
                {
                    Console.WriteLine($"\n--- EDITING CONTACT ID: {idToModify} ({names[idToModify]} {lastnames[idToModify]}) ---");

                    
                    Console.Write("New name: ");
                    names[idToModify] = Console.ReadLine();

                    
                    Console.Write("New last name: ");
                    lastnames[idToModify] = Console.ReadLine();

                    
                    Console.Write("New address: ");
                    addresses[idToModify] = Console.ReadLine();

                    
                    Console.Write("New phone number: ");
                    telephones[idToModify] = Console.ReadLine();

                    
                    Console.Write("New email: ");
                    emails[idToModify] = Console.ReadLine();

                    
                    Console.Write("New age (number): ");
                    ages[idToModify] = Convert.ToInt32(Console.ReadLine());

                    
                    Console.WriteLine("Is the user still a best friend?: 1. Yes, 2. No");
                    var temp = Convert.ToInt32(Console.ReadLine());
                    bestFriends[idToModify] = (temp == 1);

                    Console.WriteLine("\n Contact modified successfully.");
                }
                else
                {
                    Console.WriteLine($"\n Error: No contact was found with the ID {idToModify}.");
                }
            }
            break;

        case 5: 
            {
                Console.WriteLine("\nEnter the ID of the contact you want to delete");

                if (!int.TryParse(Console.ReadLine(), out int idToDelete))
                {
                    Console.WriteLine("\n Error: The ID must be a number.");
                    break;
                }

                if (ids.Contains(idToDelete))
                {
                    
                    ids.Remove(idToDelete);
                    names.Remove(idToDelete);
                    lastnames.Remove(idToDelete);
                    addresses.Remove(idToDelete);
                    telephones.Remove(idToDelete);
                    emails.Remove(idToDelete);
                    ages.Remove(idToDelete);
                    bestFriends.Remove(idToDelete);

                    Console.WriteLine($"\n Contact with ID {idToDelete} DELETED successfully.");
                }
                else
                {
                    Console.WriteLine($"\n Error: No contact was found with the ID {idToDelete}.");
                }
            }
            break;

        case 6: 
            running = false;
            Console.WriteLine("\nExiting the Contact List application. Goodbye!");
            break;

        default:
            Console.WriteLine("\nInvalid option. Please enter a number between 1 and 6.");
            break;
    }
}


static void AddContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> telephones, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> bestFriends)
{
    Console.WriteLine("\nEnter the person's name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the person's last name");
    string lastname = Console.ReadLine();
    Console.WriteLine("Enter the address");
    string address = Console.ReadLine();
    Console.WriteLine("Enter the person's phone number");
    string phone = Console.ReadLine();
    Console.WriteLine("Enter the person's email");
    string email = Console.ReadLine();
    Console.WriteLine("Enter the person's age in numbers");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Specify if they are a best friend: 1. Yes, 2. No");

    bool isBestFriend = Convert.ToInt32(Console.ReadLine()) == 1;

    var id = ids.Count + 1;
    ids.Add(id);
    names.Add(id, name);
    lastnames.Add(id, lastname);
    addresses.Add(id, address);
    telephones.Add(id, phone);
    emails.Add(id, email);
    ages.Add(id, age);
    bestFriends.Add(id, isBestFriend);

    Console.WriteLine($"\n Contact '{name} {lastname}' added successfully with ID: {id}.");
}