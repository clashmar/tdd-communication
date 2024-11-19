using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public  class BubbleSort : ISortable
    {
        public static int[] Sort(int[] arrayToSort)
        {
            if (arrayToSort.Length <= 1)
            {
                return arrayToSort;
            }

            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                if (arrayToSort[i] > arrayToSort[i + 1])
                {
                    (arrayToSort[i], arrayToSort[i+1]) = (arrayToSort[i+1], arrayToSort[i]);
                    i = 0;
                }
            }

            return arrayToSort;
        }
    }
}
