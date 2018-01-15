using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CodingInterview.Sorting
{
    public class MergeSort
    {
        
        public int[] sort(int[] num)
        {
        var orgArr = num;
        var helperArr = new int[num.Length];
        
        return DoMergeSort(orgArr, helperArr, 0, num.Length - 1);
        }

        private int[] DoMergeSort(int[] orgArr, int[] helperArr, int low, int high)
        {
            if (low >= high) return orgArr;
            var pivot = (int)Math.Floor((double)(high + low) / 2);
            DoMergeSort(orgArr, helperArr, low, pivot);
            DoMergeSort(orgArr, helperArr, pivot + 1, high);
            return Merge(orgArr, helperArr, low, pivot, high);
        }

        private int[] Merge(int[] orgArr, int[] helperArr, int low, int pivot, int high)
        {
            int helperLeft = low;
            int helperRight = pivot + 1;
            int currentPoint = low;

            while (helperLeft <= pivot && helperRight <= high)
            {
                if (helperLeft <= pivot)
                {
                    orgArr[currentPoint] = helperArr[helperLeft];
                    helperLeft++;
                }
                else
                {
                    orgArr[currentPoint] = helperArr[helperRight];
                    helperRight++;
                }
                currentPoint++;
            }

            if (helperLeft <= pivot)
            {
                while (helperLeft <= pivot)
                {
                    orgArr[currentPoint] = helperArr[helperLeft];
                    helperLeft++;
                    currentPoint++;
                }
            }
            if (helperRight <= high)
            {
                while (helperRight <= high)
                {
                    orgArr[currentPoint] = helperArr[helperRight];
                    helperRight++;
                    currentPoint++;
                }
            }
            return orgArr;
        }
    }
}
