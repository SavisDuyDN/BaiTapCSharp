using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SinhVien : Person
    {
        public int ID { get; set; }
        public int MediumScore { get; set; }
        public string Email { get; set; }

        public override void InputInfo()
        {
            base.InputInfo();
            Console.Write("Nhap Vao Ma Sinh Vien: ");
            this.ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Diem Trung Binh: ");
            this.MediumScore = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Vao Email: ");
            this.Email = Console.ReadLine();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.Write("Ma SV: {0} \n Diem Trung Binh : {1} \n Email : {2}", this.ID, this.MediumScore, this.Email);
            if(this.MediumScore > 8.5)
            {
                Console.WriteLine("\n Hoc Sinh {0} Duoc Hoc Bong", this.Name);
            }
        }
    }
}
