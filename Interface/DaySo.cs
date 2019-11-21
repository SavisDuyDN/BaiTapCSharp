using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class DaySo
    {
        public int Nhap()
        {
            Console.Write("Nhap So: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        public void Print(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
        }
        public int[] CreateDaySo(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                int numberInput = Nhap();
                numbers[i] = numberInput;
            }
            return numbers;
        }
    }
}
