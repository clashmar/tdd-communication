using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata1
    {
        public static int SumMiddleNumbers(int[] array)
        {
            int count = 0;

            Array.Sort(array);

            for(int i = 1; i < array.Length - 1; i++)
            {
                count += array[i];
            }

            return count;
        }
    }
}
