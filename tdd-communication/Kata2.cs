using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_communication
{
    public class Kata2
    {
        public static double CalculateMean(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            int sum = 0;
            double mean;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Length; 

            return mean;
        }



    }
}
