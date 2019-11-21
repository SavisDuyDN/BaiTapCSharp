using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            PhoneBook phoneBook = new PhoneBook();
            do
            {
                Console.Write("Chon Menu: ");
                int menuChoose = Convert.ToInt32(Console.ReadLine());
                menu = menuChoose;
                switch (menuChoose)
                {
                    case 1:
                        Console.Write("nhap vao ten: ");
                        string name = Console.ReadLine();
                        Console.Write("nhap vao sdt: ");
                        string phone = Console.ReadLine();
                        phoneBook.InsertPhone(name, phone);
                        break;
                    case 2:
                        Console.WriteLine("==============");
                        Console.Write("nhap vao ten: ");
                        string nameUpdate = Console.ReadLine();
                        Console.Write("nhap vao sdt: ");
                        string phoneUpdate = Console.ReadLine();
                        phoneBook.UpdatePhone(nameUpdate, phoneUpdate);
                        break;
                    case 3:
                        Console.WriteLine("==============");
                        Console.Write("nhap vao ten: ");
                        string nameDelete = Console.ReadLine();
                        phoneBook.DeletePhone(nameDelete);
                        break;
                    case 4:
                        Console.WriteLine("==============");
                        Console.Write("nhap vao ten: ");
                        string nameSearch = Console.ReadLine();
                        phoneBook.SearchPhone(nameSearch);
                        break;
                    case 5:
                        Console.Write("Thoat..!");
                        break;
                    default:
                        break;
                }
            } while (true);

        }
    }
}
