using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class QuickSort : Sort
    {
        public int[] Sort(int[] arr)
        {
            int[] arrSorted = CreateQuickSort(arr, 0, (arr.Length - 1));
            return arrSorted;
        }
        public int[] CreateQuickSort(int[] arr, int left, int right)
        {
            int mid = arr[(left + right) / 2];
            int i = left,
                j = right;
            do
            {
                while (arr[i] < mid)
                {
                    i++;
                }
                while (arr[j] > mid)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            } while (i < j);
            if (left < j)
            {
                CreateQuickSort(arr,left, j);
            }
            if(i < right)
            {
                CreateQuickSort(arr,i, right);
            }
            return arr;
        }
    }
}
