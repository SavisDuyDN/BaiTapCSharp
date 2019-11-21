using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
           
            do
            {
                Console.WriteLine("nhap vao so bo test");
                t = int.Parse(Console.ReadLine());
            }
            // nếu t nhỏ hơn 1 hoặc lớn 10 thì bắt nhập lại
            while (t < 1 || t >= 10);
            while(t > 0)
            {
                long a = long.Parse(Console.ReadLine());
                long b = long.Parse(Console.ReadLine());
                long m = long.Parse(Console.ReadLine());
                long k = long.Parse(Console.ReadLine());

                long cur = b % m; // lấy ra x hiện tại
                long prev = 0; // khai báo x trước đó
                // khi k nhập vào < 0 thì dừng
                while(k > 0)
                {
                    long next = a * cur % m + b % m;
                    prev = cur; //prev == xk-1
                    cur = next; //tmp == xk
                    k--;
                }

                Console.WriteLine(prev);
                t--;
            }
            Console.ReadKey();
        }
    }
}
