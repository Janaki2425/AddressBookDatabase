using System;
namespace AddressBookDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook Service");

            AddressRepo repo = new AddressRepo();
            AddressModel address = new AddressModel();
            address.FirstName = "Bruce";
            address.LastName = "layn";
            address.Address = "3-356";
            address.State = "TamilNadu";
            address.ZIP = "600051";
            address.PhoneNumber = "9637592638";
            address.City = "Chennai";
            address.Email = "anc@gmail.com";

            address.FirstName = "Tom";
            address.LastName = "Hardy";
            address.Address = "3-234";
            address.State = "Karnataka";
            address.ZIP = "200091";
            address.PhoneNumber = "8639092638";
            address.City = "Bangalore";
            address.Email = "nnn@gmail.com";

            address.FirstName = "Bruce";
            address.LastName = "layn";
            address.Address = "1-35";
            address.State = "Andhra Pradesh";
            address.ZIP = "700091";
            address.PhoneNumber = "7987592638";
            address.City = "Hyderabad";
            address.Email = "ieh@gmail.com";

            repo.AddAddress(address);
            repo.GetAllAddress();

        }
    }
}