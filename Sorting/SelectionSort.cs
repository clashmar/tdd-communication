using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort : ISortable
    {
        public static int[] Sort(int[] arrayToSort)
        {
            if (arrayToSort.Length <= 1)
            {
                return arrayToSort;
            }

            List<int> ogList = arrayToSort.ToList();
            List<int> newList = new List<int>();

            //Loop through and find smallest number
            while(ogList.Count > 0)
            {
                int smallestIndex = 0;

                for(int i = 1; i < ogList.Count; i++)
                {
                    if(ogList[i] < ogList[smallestIndex])
                    {
                        smallestIndex = i;
                    }
                }
                newList.Add(ogList[smallestIndex]);
                ogList.Remove(ogList[smallestIndex]);
            }

            return newList.ToArray();
        }
    }
}
