using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            // chuyển cơ số 10 sang 2

            //Console.Write("Nhap So Can Chuyen :");
            //long number = Convert.ToInt32(Console.ReadLine());
            //List<long> listNumber = new List<long>();
            //do
            //{
            //    long surplus = number % 2;
            //    listNumber.Add(surplus);
            //    long halfNumber = number / 2;
            //    number = halfNumber;
            //    if(number == 1)
            //    {
            //        listNumber.Add(1);
            //    }
            //} while (number != 1);
            //for (int i = listNumber.Count(); i > 0; i--)
            //{
            //    Console.Write(listNumber[i-1]);
            //}

            // chuyển hệ cơ số 16 sang 2

            //Console.Write("Nhap Chu Hoac So Can Chuyen: ");
            //string strInput = Console.ReadLine();
            //string strHex = "";
            //for (int i = 0; i < strInput.Length; i++)
            //{
            //    string strSubtring = strInput.Substring(i, 1);
            //    switch (strSubtring)
            //    {
            //        case "0": strHex += "0000"; break;
            //        case "1": strHex += "0001"; break;
            //        case "2": strHex += "0010"; break;
            //        case "3": strHex += "0011"; break;
            //        case "4": strHex += "0100"; break;
            //        case "5": strHex += "0101"; break;
            //        case "6": strHex += "0110"; break;
            //        case "7": strHex += "0111"; break;
            //        case "8": strHex += "1000"; break;
            //        case "9": strHex += "1001"; break;
            //        case "A": strHex += "1010"; break;
            //        case "B": strHex += "1011"; break;
            //        case "C": strHex += "1100"; break;
            //        case "D": strHex += "1101"; break;
            //        case "E": strHex += "1110"; break;
            //        case "F": strHex += "1111"; break;
            //        default:
            //            strHex += "";
            //            break;
            //    }
            //}
            //Console.WriteLine(strHex);

            // Chuyển hệ số 8 sang 2

            //Console.Write("Nhap So Can Chuyen: ");
            //string strInput = Console.ReadLine();
            //string strOctal = "";
            //for (int i = 0; i < strInput.Length; i++)
            //{
            //    string strSubtring = strInput.Substring(i, 1);
            //    switch (strSubtring)
            //    {
            //        case "0": strOctal += "000"; break;
            //        case "1": strOctal += "001"; break;
            //        case "2": strOctal += "010"; break;
            //        case "3": strOctal += "011"; break;
            //        case "4": strOctal += "100"; break;
            //        case "5": strOctal += "101"; break;
            //        case "6": strOctal += "110"; break;
            //        case "7": strOctal += "111"; break;
            //        default:
            //            strOctal += "";
            //            break;
            //    }
            //}
            //Console.WriteLine(strOctal);

            // Hàm Chuẩn Hóa Chuỗi
            Console.Write("Moi Nhap Chuoi Can Chuan Hoa: ");
            string strInput = Console.ReadLine();
            strInput = strInput.Trim();
            while (strInput.IndexOf("  ") != -1)
            {
                strInput = strInput.Replace("  ", " ");
            }
            string strOutput = "";
            string[] arr = strInput.Split(' ');
            foreach (var item in arr)
            {
                string strFirstChar = item.Substring(0, 1);
                string otherChar = item.Substring(1).ToLower();
                strFirstChar = strFirstChar.ToUpper();
                string strItem = strFirstChar + otherChar;
                strOutput += strItem + " ";
            }
            Console.Write("Ho Ten: " + strOutput.TrimEnd());
            Console.ReadKey();
        }
    }
}
