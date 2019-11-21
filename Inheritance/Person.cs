using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }

        public virtual void InputInfo()
        {
            Console.Write("Nhap Vao Ten :");
            this.Name = Console.ReadLine();
            Console.Write("Nhap Vao Gioi Tinh :");
            this.Sex = Console.ReadLine();
            Console.Write("Nhap Vao Ngay Sinh :");
            this.Birthday = Console.ReadLine();
            Console.Write("Nhap Vao Dia Chi :");
            this.Address = Console.ReadLine();
        }
        public virtual void ShowInfo()
        {
            Console.Write("Ten: {0} \nGioi Tinh: {1} \nNgay Sinh: {2} \nDia Chi: {3} \n", this.Name, this.Sex, this.Birthday, this.Address);
        }
    }
}
