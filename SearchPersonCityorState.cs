using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
  
    
        public class SearchPersonCityorState
    {

        public static List<ContactDetails> AddressBook = new List<ContactDetails>();
        public static Dictionary<string, List<ContactDetails>> City = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> State = new Dictionary<string, List<ContactDetails>>();
        public List<ContactDetails> stateList;
        public List<ContactDetails> cityList;
        public List<ContactDetails> people;
        public SearchPersonCityorState()
        {
            AddressBook = new List<ContactDetails>();
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
}
       
    




    





