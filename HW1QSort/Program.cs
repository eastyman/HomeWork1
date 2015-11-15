using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1QSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 15, 1, 2, 3, 4, 5, 10, 89, 75, 12 };
            int lastInd = array.Length - 1;
            QuickSortInc(array, 0, lastInd);
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }

        }
        static void QuickSortInc(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last)
                {
                    ++i;
                }
                while (arr[j] > p && j >= first) 
                { 
                    --j; 
                }
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > first)
            {
                QuickSortInc(arr, first, j);
            }
            if (i < last)
            {
                QuickSortInc(arr, i, last);
            }
        }  
    }
}

