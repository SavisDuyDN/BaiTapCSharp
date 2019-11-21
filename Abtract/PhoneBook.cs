using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    public class PhoneBook : Phone
    {
        public string name { get; set; }
        public string phone { get; set; }
        public string newPhone { get; set; }
        List<PhoneBook> phoneBooks = new List<PhoneBook>();
        public override void DeletePhone(string name)
        {
            if (phoneBooks.Any(n => n.name == name))
            {
                phoneBooks.Where(n => n.name == name).FirstOrDefault().name = null;
                Console.Write("Deleted\n");
            }
            else
            {
                Console.Write("Ten khong Ton Tai\n");
            }
        }

        public override void InsertPhone(string name, string phone)
        {
            if(phoneBooks.Any(n=>n.name == name))
            {
                phoneBooks.FirstOrDefault(n => n.name == name).newPhone = phone;
                Console.Write("Inserted\n");

            }
            else
            {
                PhoneBook phoneBook = new PhoneBook();
                phoneBook.phone = phone;
                phoneBook.name = name;
                phoneBooks.Add(phoneBook);
                Console.Write("Inserted\n");
            }
        }

        public override void SearchPhone(string name)
        {
            Console.Write(phoneBooks.FirstOrDefault(n => n.name == name).phone);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            if (phoneBooks.Any(n=>n.name == name))
            {
                phoneBooks.FirstOrDefault(n => n.name == name).phone = newPhone;
                Console.Write("Updated\n");
            }
            else
            {
                Console.Write("Ten khong Ton Tai\n");
            }
        }
    }
}
