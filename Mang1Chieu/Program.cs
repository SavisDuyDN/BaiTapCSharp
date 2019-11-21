using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Moi Ban Nhap So Phan Tu: ");
            int intMaxItem = int.Parse(Console.ReadLine());

            int[] arr = new int[intMaxItem];
            for (int i = 0; i < intMaxItem; i++)
            {
                Console.WriteLine("Phan Tu thu {0}:", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Mang ban vua Nhap La: ");
            foreach (var item in arr)
            {
                Console.Write(item +" ");
            }
            int max = arr[0];
            int maxIndex = 0;
            int minIndex = 0;
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                }
                if(min > arr[i])
                {
                    min = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == max)
                {
                    maxIndex = i;
                }
                if(arr[i] == min)
                {
                    minIndex = i;
                }
            }
            Console.WriteLine("/n so lon nhat la: " + max+", chi so :"+maxIndex);
            Console.WriteLine("so nho nhat la: " + min +", chi so :"+ minIndex);

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("\n Cac phan tu mang theo thu tu giam dan:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("\n Cac phan tu mang theo thu tu tang dan:\n");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }

            Console.ReadKey();
        }
    }
}
