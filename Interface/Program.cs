using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap Vao So luong phan tu: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());
            DaySo daySo = new DaySo();
            var arr = daySo.CreateDaySo(maxNumber);

            //InsertSort insertSort = new InsertSort();
            //var arrInsertSort = insertSort.Sort(arr);
            //foreach (var item in arrInsertSort)
            //{
            //    Console.Write(item);
            //}

            //QuickSort quickSort = new QuickSort();
            //int[] arrOutput = quickSort.Sort(arr);
            //foreach (var item in arrOutput)
            //{
            //    Console.Write(item);
            //}

            SelectionSort selectionSort = new SelectionSort();
            int[] arrOutput = selectionSort.Sort(arr);
            foreach (var item in arrOutput)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
