using System;
namespace addressbook
{
    internal class Program
    {


        static void Main(string[] args)
        {

            ContactDetails contactDetail = new ContactDetails();
            contactDetail.Details();
           AddContact addNewContact = new AddContact();
            addNewContact.EnterInput();
            addNewContact.ViewTheDetails();
            EditContact editDetails = new EditContact();
            editDetails.EditName();
            DeleteContact deleteDetails = new DeleteContact();
            deleteDetails.DeleteName();
            ViewPerson viewPerson=new ViewPerson();
            viewPerson.ViewTheDetails();

            
            

        }
    }
}
        


            


            






    



    

