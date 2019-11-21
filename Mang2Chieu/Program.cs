using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap So Hang: ");
            int intRowNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap Cot Hang: ");
            int intColNumber = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[intRowNumber, intColNumber];
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = 0; j < intColNumber; j++)
                {
                    Console.Write("Nhap Phan Tu Thu Arr[{0},{1}]: ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("Cac Phan Tu Cua Mang 2 Chieu : ");
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = 0; j < intColNumber; j++)
                {
                    Console.Write("\nArr[{0},{1}]: {2} \n", i, j, arr[i, j]);
                }
            }

            int temp;
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = 0; j < intColNumber; j++)
                {
                    for (int z = j + 1; z < intColNumber; z++)
                    {
                        if (arr[i, j] > arr[i,z])
                        {
                            temp = arr[i, j];
                            arr[i,j] = arr[i,z];
                            arr[i,z] = temp;
                        }
                    }

                }
            }
            Console.Write("Cac Phan Tu Cua Mang 2 Chieu Tang Dan Theo Hang : ");
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = 0; j < intColNumber; j++)
                {
                    Console.Write("\nArr[{0},{1}]: {2} \n", i, j, arr[i, j]);
                }
            }
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = i + 1; j < intRowNumber; j++)
                {
                    for (int z = 0; z < intColNumber; z++)
                    {
                        if (arr[i,z] > arr[j,z])
                        {
                            temp = arr[i,z];
                            arr[j, z] = arr[i, z];
                            arr[j, z] = temp;
                        }
                    }
                }
            }
            Console.Write("Cac Phan Tu Cua Mang 2 Chieu Tang Dan Theo Cot : ");
            for (int i = 0; i < intRowNumber; i++)
            {
                for (int j = 0; j < intColNumber; j++)
                {
                    Console.Write("\nArr[{0},{1}]: {2} \n", i, j, arr[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
