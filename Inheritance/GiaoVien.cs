using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GiaoVien : Person
    {
        public int classId { get; set; } 
        public decimal moneyInHour { get; set; } 
        public int hourInMonth { get; set; } 
        public int seniority { get; set; }

        public override void InputInfo()
        {
            base.InputInfo();
            Console.Write("Nhap Vao Ma Lop Day: ");
            this.classId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Luong Day 1 Gio: ");
            this.moneyInHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao So Gio 1 Thang: ");
            this.hourInMonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Tham Nien: ");
            this.seniority = Convert.ToInt32(Console.ReadLine());
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("\nMa Lop: {0} \nThoi Luong: {1} \nSo Gio 1 Thang: {2} \nTham Nien: {3}\n", this.classId, this.moneyInHour, this.hourInMonth, this.seniority);
        }
        public decimal TinhLuong()
        {
            if (this.seniority < 1)
            {
                return (this.moneyInHour * this.hourInMonth);
            }
            else if (this.seniority < 3 )
            {
                return this.moneyInHour * this.hourInMonth * Convert.ToDecimal(1.1);
            }
            else if (this.seniority < 5)
            {
                return this.moneyInHour * this.hourInMonth * Convert.ToDecimal(1.3);
            }
            else
            {
                return this.moneyInHour * this.hourInMonth * Convert.ToDecimal(1.5);
            }
        }
    }
}
