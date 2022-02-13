using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    internal class ViewPerson
    {
        public static List<ContactDetails> AddressBook = new List<ContactDetails>();
        public static Dictionary<string, List<ContactDetails>> City = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> State = new Dictionary<string, List<ContactDetails>>();
        public List<ContactDetails> stateList;
        public List<ContactDetails> cityList;
        public List<ContactDetails> people;
        public ViewPerson()
        {
            people = new List<ContactDetails>();
        }
        public void EnterInput()

        {
            Console.WriteLine("enter how many contacts you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                ContactDetails contacts = new ContactDetails();
                Console.WriteLine("Enter the First name:");
                contacts.FirstName = Console.ReadLine();
                foreach (var item in AddContact.AddressBook)

                    while (true)
                    {

                        if (contacts.FirstName.ToLower() != item.FirstName.ToLower())
                        {
                            Console.WriteLine(contacts.FirstName);
                            break;

                        }

                        else
                        {
                            Console.WriteLine("First name already exists!! Duplicate Element not allowed.");


                        }
                    }
                Console.WriteLine("Enter the last Name  : ");
                contacts.LastName = Console.ReadLine();

                Console.WriteLine("Enter the address  : ");
                contacts.Address = Console.ReadLine();

                Console.WriteLine("Enter the City  : ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter the state : ");
                contacts.State = Console.ReadLine();


                while (true)
                {
                    Console.WriteLine("Enter Zip Code  : ");
                    string code = Console.ReadLine();

                    if (code.Length == 6)
                    {
                        contacts.Zip = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter Your Phone Number: ");
                    string number = Console.ReadLine();

                    if (number.Length == 10)
                    {
                        contacts.PhoneNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter Your Email Address: ");
                    string mail = Console.ReadLine();

                    if (mail.Contains("@"))
                    {
                        contacts.Email = mail;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Email Address.");
                    }
                }

                AddressBook.Add(contacts);

                Console.WriteLine("..................");

            }


        }



        public void ViewTheDetails()
        {
            if (AddressBook.Count > 0)
            {
                foreach (var item in AddressBook)
                {
                    PrintTheDetails(item);

                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");

            }

        }
        public void PrintTheDetails(ContactDetails item)
        {
            Console.WriteLine("First Name :   " + item.FirstName);
            Console.WriteLine("Last Name :    " + item.LastName);
            Console.WriteLine("Address :      " + item.Address);
            Console.WriteLine("City    :      " + item.City);
            Console.WriteLine("State   :      " + item.State);
            Console.WriteLine("Zip     :      " + item.Zip);
            Console.WriteLine("Phone Number  : " + item.PhoneNumber);
            Console.WriteLine("email  :       " + item.Email);


        }
    }

    public static void StoreCity(string key, List<ContactDetails> AddressBook, string city)
    {
        List<ContactDetails> CityList = AddressBook.FindAll(x => x.City.Equals(city)).ToList();
        foreach (var i in CityList)
        {
            Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in City {2}", i.FirstName, key, i.City);
        }
    }

    public static void StoreState(string key, List<ContactDetails> AddressBook, string state)
    {
        List<ContactDetails> StateList = AddressBook.FindAll(x => x.state.Equals(state)).ToList();
        foreach (var i in StateList)
        {
            Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in State {2}", i.FirstName, key, i.State);
        }
    }
    public static void DisplayCityorState()
    {
        Console.WriteLine("Enter 1-To view City list\n Enter 2-To view State list");
        int citystate = Convert.ToInt32(Console.ReadLine());
        if (citystate == 1)
        {
            foreach (var i in City)
            {
                Console.WriteLine("Display List for City: {0}\n", i.Key);
                foreach (var j in i.Value)
                {
                    Console.WriteLine("Found person \"{0} {1}\" , residing in City {2}", j.firstName, j.lastName, j.city);
                }


            }
        }
        else
        {
            foreach (var a in State)
            {
                Console.WriteLine("Display List for State: {0}\n", a.Key);
                foreach (var b in a.Value)
                {
                    Console.WriteLine("Found person \"{0} {1}\" , residing in State {2}", b.firstName, b.lastName, b.state);
                }

            }
        }
    }
}



        
    

    

