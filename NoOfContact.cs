using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    internal class NoOfContact
    {
        public static List<ContactDetails> AddressBook = new List<ContactDetails>();
        public static Dictionary<string, List<ContactDetails>> person = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> City = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> State = new Dictionary<string, List<ContactDetails>>();
        public List<ContactDetails> stateList;
        public List<ContactDetails> cityList;
        public List<ContactDetails> people;
        public NoOfContact()
        {
            people = new List<ContactDetails>();
        }

        public void GetCustomer(string firstName, string lastName, string phoneNum, string address, string city, string state, string zipCode, string emailId)
        {
            int contact = 0;
            ContactDetails person = new ContactDetails(firstName, lastName, phoneNum, address, city, state, zipCode, emailId);
            if (contact == 0)
            {

                people.Add(person);
                if (State.ContainsKey(state))
                {
                    List<ContactDetails> existing = State[state];
                    existing.Add(person);

                }
                else
                {
                    stateList = new List<ContactDetails>();
                    stateList.Add(person);
                    State.Add(state, stateList);

                }
                if (City.ContainsKey(city))
                {
                    List<ContactDetails> existing = City[city];
                    existing.Add(person);

                }
                else
                {
                    cityList = new List<ContactDetails>();
                    cityList.Add(person);
                    City.Add(city, cityList);

                }
                contact++;
            }
            else if (contact != 0)
            {
                ContactDetails addressBookSystems = people.Find(x => x.FirstName.Equals(firstName));
                if (addressBookSystems == null)
                {
                    person = new ContactDetails(firstName, lastName, address, city, state, zipCode, phoneNum, emailId);
                    people.Add(person);
                    if (State.ContainsKey(state))
                    {
                        List<ContactDetails> existing = State[state];
                        existing.Add(person);

                    }
                    else
                    {
                        stateList = new List<ContactDetails>();
                        stateList.Add(person);
                        State.Add(state, stateList);

                    }
                    if (City.ContainsKey(city))
                    {
                        List<ContactDetails> existing = City[city];
                        existing.Add(person);

                    }
                    else
                    {
                        cityList = new List<ContactDetails>();
                        cityList.Add(person);
                        City.Add(city, cityList);

                    }
                    contact++;
                }
                else
                {
                    Console.WriteLine("This person already exists in your AddressBook!");
                }

            }
        }
    }
}
