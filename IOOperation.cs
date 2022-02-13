using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook
{
    internal class IOOperation
    {
        const string filepath = @"C:\Users\91936\source\repos\RefactorAddressbook\RefactorAddressbook\intro.txt";

        public static void GetDictionary(Dictionary<string, List<ContactDetails>> addressbooknames)
        {
            File.WriteAllText(filepath, string.Empty);
            foreach (KeyValuePair<string, List<ContactDetails>> key in addressbooknames)
            {
                File.AppendAllText(filepath, "Address Book: " + key.Key + Environment.NewLine);
                foreach (var member in key.Value)
                {
                    File.AppendAllText(filepath, member.ToString() + Environment.NewLine);
                }
                File.AppendAllText(filepath, Environment.NewLine);
                Console.WriteLine("content written :");
                ReadAddressBook();
            }

        }
        public static void ReadAddressBook()
        {
            try
            {
                string[] text = File.ReadAllLines(filepath);
                foreach (var v in text)
                 Console.WriteLine(v);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

    

