using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            // bài 1:  phân số
            PhanSo phanSo = new PhanSo();
            phanSo.InputFractions();
            PhanSo phanSo2 = new PhanSo();
            phanSo2.InputFractions();
            Console.Write(phanSo.Add(phanSo2.numerator, phanSo2.denominator));
            Console.Write("\n" +phanSo.Minus(phanSo2.numerator, phanSo2.denominator));
            Console.Write("\n" + phanSo.Analysis(phanSo2.numerator, phanSo2.denominator));
            Console.Write("\n" + phanSo.Division(phanSo2.numerator, phanSo2.denominator));

            Console.ReadKey();
        }
    }
}
