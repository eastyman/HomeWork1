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
            int middleElem = arr[(last - first) / 2 + first];
            int temp;
            int leftElem = first, rightElem = last;
            while (leftElem <= rightElem)
            {
                while (arr[leftElem] < middleElem && leftElem <= last)
                {
                    ++leftElem;
                }
                while (arr[rightElem] > middleElem && rightElem >= first) 
                { 
                    --rightElem; 
                }
                if (leftElem <= rightElem)
                {
                    temp = arr[leftElem];
                    arr[leftElem] = arr[rightElem];
                    arr[rightElem] = temp;
                    ++leftElem;
                    --rightElem;
                }
            }
            if (rightElem > first)
            {
                QuickSortInc(arr, first, rightElem);
            }
            if (leftElem < last)
            {
                QuickSortInc(arr, leftElem, last);
            }
        }  
    }
}

