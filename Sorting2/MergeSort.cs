using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting2
{
    public class MergeSort
    {
        public static void Merge(int[] arr,int start,int m, int end)
        {   
            List<int> temp = new List<int>();

            int i = start;int j = m+1;
            
            while (i <= m && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp.Add(arr[i]);
                    i++;
                }
                else {
                    temp.Add(arr[j]);
                    j++;
                }
            }

            while (i <= m)
            {
                temp.Add(arr[i]);
                i++;
            }
            while (j <= end)
            {
                temp.Add(arr[j]);
                j++;
            }

            for (int index = 0; index < temp.Count; index++) {
                arr[index+start]=temp[index];
            }

        }
        public static void Divide_Conqure(int[] arr,int start, int end)
        {
            if (start >= end)
                return;
            int m = start+(end-start)/2;
            Divide_Conqure(arr,start,m);
            Divide_Conqure(arr,m+1,end);
            Merge(arr,start,m,end);
        }
        public static int[] Sorting(int[] arr)
        {
            Divide_Conqure(arr,0,arr.Length-1);
            return arr;
        }

    }
}
