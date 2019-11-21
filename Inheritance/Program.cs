using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // bài 3 : kế thừa
            // Phần 4


            //int menu;
            //List<SinhVien> sinhViens = new List<SinhVien>();
            //do
            //{
            //    Console.Write("\n Chon menu: ");
            //    int menuChoose = Convert.ToInt32(Console.ReadLine());
            //    menu = menuChoose;
            //    switch (menu)
            //    {
            //        case 1:
            //            Console.Write("Nhap Vao So Luong Sinh Vien: ");
            //            int intCountSv = Convert.ToInt32(Console.ReadLine());
            //            for (int i = 0; i < intCountSv; i++)
            //            {
            //                SinhVien sinhVien = new SinhVien();
            //                sinhVien.InputInfo();
            //                Console.Write("================= \n");
            //                sinhViens.Add(sinhVien);
            //            }
            //            break;
            //        case 2:
            //            if (sinhViens.Any())
            //            {
            //                Console.Write("================= \n");
            //                foreach (var item in sinhViens)
            //                {
            //                    item.ShowInfo();
            //                }
            //            }
            //            else
            //            {
            //                Console.Write("Khong Co Sinh Vien Nao");
            //            }
            //            break;
            //        case 3:
            //            Console.Write("================= \n");
            //            int intMaxScore = sinhViens.Max(n => n.MediumScore);
            //            int intMinScore = sinhViens.Min(n => n.MediumScore);
            //            var svMaxScore = sinhViens.Where(n => n.MediumScore == intMaxScore).FirstOrDefault();
            //            svMaxScore.ShowInfo();
            //            var svMinScore = sinhViens.Where(n => n.MediumScore == intMinScore).FirstOrDefault();
            //            svMinScore.ShowInfo();
            //            break;
            //        case 4:
            //            Console.Write("================= \n");
            //            Console.Write("Nhap Vao Id");
            //            int ID = Convert.ToInt32(Console.ReadLine());
            //            var sinhvien = sinhViens.FirstOrDefault(n => n.ID == ID);
            //            if(sinhvien == null)
            //            {
            //                Console.Write("\n Khong Co Sinh Vien Nao Co ID = {0}", ID);
            //            }
            //            else
            //            {
            //                sinhvien.ShowInfo();
            //            }
            //            break;
            //        case 5:
            //            Console.Write("================= \n");
            //            var lstSinhVien = sinhViens.Where(n => n.MediumScore > 8.5).OrderByDescending(n => n.MediumScore).ToList();
            //            foreach (var item in lstSinhVien)
            //            {
            //                item.ShowInfo();
            //            }
            //            break;
            //        case 6:
            //            Console.Write("================= \n");
            //            Console.Write("Thoat...!");
            //            break;
            //        default:
            //            break;
            //    }
            //} while (menu != 6);


            // phần 5

            List<GiaoVien> giaoViens = new List<GiaoVien>();
            int menuChoose;
            do
            {
                Console.Write("Chon Menu: ");
                int menu = Convert.ToInt32(Console.ReadLine());
                menuChoose = menu;
                switch (menu)
                {
                    case 1:
                        Console.Write("Nhap Vao So Giang Vien: ");
                        int countTeacher = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < countTeacher; i++)
                        {
                            GiaoVien giaoVien = new GiaoVien();
                            giaoVien.InputInfo();
                            giaoViens.Add(giaoVien);
                            Console.Write("================= \n");
                        }
                        break;
                    case 2:
                        foreach (var item in giaoViens)
                        {
                            Console.Write("=============\n");
                            item.ShowInfo();
                        }
                        break;
                    case 3:
                        decimal money = giaoViens.Max(n => n.TinhLuong());
                        var gv = giaoViens.Where(n=>n.TinhLuong() == money).FirstOrDefault();
                        Console.Write("=============\n");
                        gv.ShowInfo();
                        Console.Write("=============\n");
                        break;
                    case 4:
                        Console.Write("=============\n");
                        Console.Write("Thoat...!");
                        break;
                    default:
                        break;
                }
            } while (menuChoose != 4);
            Console.ReadKey();
        }
    }
}
