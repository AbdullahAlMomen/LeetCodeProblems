using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting1
{
    public static class SelectionSort
    {
        public static int[] Sorting(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;

            }
            return array;

        }
    }
}
